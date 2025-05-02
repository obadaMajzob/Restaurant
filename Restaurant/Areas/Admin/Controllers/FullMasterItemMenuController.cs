using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Restaurant.Extensions;
using Restaurant.Helpers.File;
using Restaurant.Models;
using Restaurant.Repositories;
using Restaurant.ViewModels;

namespace Restaurant.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class FullMasterItemMenuController : Controller
    {
        IRepository<MasterItemMenu> ItemMenuRepository;
        IRepository<MasterCategoryMenu> CategoryMenuRepository;
        IFileHelper FileHelper;


        public FullMasterItemMenuController(IRepository<MasterItemMenu> itemMenuRepository, IRepository<MasterCategoryMenu> categoryMenuRepository, IFileHelper fileHelper)
        {
            ItemMenuRepository=itemMenuRepository;
            CategoryMenuRepository=categoryMenuRepository;
            FileHelper=fileHelper;
        }



        public IActionResult Index()
        {
            var data = ItemMenuRepository.View();
            var datapVm = data.ToListViewModel();

            var category = CategoryMenuRepository.View();
            foreach (var item in datapVm)
            {

                //item.MasterCategoryMenu = CategoryMenuRepository.Find(/*(int)*/item.MasterCategoryMenuId.Value);

                item.MasterCategoryMenuId = item.MasterCategoryMenuId==null ? 0 : item.MasterCategoryMenuId.Value;

                //if (item.MasterCategoryMenuId.HasValue)
                //{
                //    item.MasterCategoryMenu = CategoryMenuRepository.Find((int)item.MasterCategoryMenuId);
                //}
            }


            var obj = new MasterFullItemMenuViewModel
            {

                MasterItemMenuViewModelss = datapVm,
                ListOfCategory = new SelectList(category, "Id", "MasterCategoryMenuName")

            };
            return View(obj);
        }






        [HttpPost]
        public IActionResult Save(MasterFullItemMenuViewModel model)
        {
        
            if (model.Id == 0)
            {
                Creat(model);
            }
            else
            {
                Edit(model);
            }
            return RedirectToAction(nameof(Index));


        }



        public void Creat(MasterFullItemMenuViewModel model)
        {
            
                var userId = User.Identity.Name;
               
                var imageName = FileHelper.SaveImage(model.ImageFile, "", "Images");

                var obj = new MasterItemMenu
                    {

                        Id = model.Id,
                        MasterItemMenuTitle = model.MasterItemMenuTitle,
                        MasterItemMenuDesc = model.MasterItemMenuDesc,
                        MasterItemMenuPrice = model.MasterItemMenuPrice,    
                        MasterItemMenuBreef = model.MasterItemMenuBreef,
                        MasterItemMenuDate = model.MasterItemMenuDate,
                        MasterCategoryMenuId = model.MasterCategoryMenuId,
                        MasterItemMenuImageUrl = imageName, 

                        CreateId = userId,


                    };
                if (imageName != "Error")
                {
                    ItemMenuRepository.Add(obj);
                }
            


        }


        public void Edit(MasterFullItemMenuViewModel model)
        {

            var userId = User.Identity.Name;
            var imageName = FileHelper.SaveImage(model.ImageFile, model.MasterItemMenuImageUrl, "Images");

            var obj = new MasterItemMenu
            {
                Id = model.Id,
                MasterItemMenuTitle = model.MasterItemMenuTitle,
                MasterItemMenuDesc = model.MasterItemMenuDesc,
                MasterItemMenuPrice = model.MasterItemMenuPrice,
                MasterItemMenuBreef = model.MasterItemMenuBreef,
                MasterItemMenuDate = model.MasterItemMenuDate,
                MasterItemMenuImageUrl = imageName,

                EditId = userId,


            };
            if (imageName != "Error" )
            {
                ItemMenuRepository.Update(model.Id, obj);

            }

        }



        public IActionResult Delete(MasterFullItemMenuViewModel model)
        {
            var userId = User.Identity.Name;
            var obj = new MasterItemMenu();
            obj.DeleteId = userId; 
            
            ItemMenuRepository.Delete(model.Id,obj);
            return RedirectToAction(nameof(Index));

        }

        public IActionResult ChangeStatus(int id, IFormCollection collection)
        {

            var userId = User.Identity.Name;
            var obj = new MasterItemMenu();
            obj.EditId = userId;

            ItemMenuRepository.ChangeStatus(id, obj);
            return RedirectToAction(nameof(Index));

        }








        //public IActionResult Index()
        //{
        //    var data = ItemMenuRepository.View();
        //    var datapVm = data.ToListViewModel();

        //    var category = CategoryMenuRepository.View();
        //    foreach (var item in datapVm)
        //    {
        //        //item.MasterCategoryMenuId = item.MasterCategoryMenuId==null ? 0 : item.MasterCategoryMenuId.Value;

        //        item.MasterCategoryMenu = CategoryMenuRepository.Find(/*(int)*/item.MasterCategoryMenuId.Value);

        //    }

        //    var obj = new MasterFullItemMenuViewModel
        //    {

        //        MasterItemMenuViewModelss = datapVm,
        //        ListOfCategory = new SelectList(category, "Id", "MasterCategoryMenuName")

        //    };
        //    return View(obj);
        //}





        //public IActionResult Index()
        //{
        //    var Categories = CategoryMenuRepository.View().ToListViewModel();
        //    var obj = new MasterFullItemMenuViewModel
        //    {
        //        MasterItemMenuViewModelss=ItemMenuRepository.View().ToListViewModel(),
        //        ListOfCategory=new SelectList(Categories,"Id", "MasterCategoryMenuName"),
        //    };
        //    foreach (var item in obj.MasterItemMenuViewModelss)
        //    {
        //        //    item.MasterCategoryMenu=CategoryMenuRepository.Find(item.MasterCategoryMenuId);


        //    }
        //    return View(obj);
        //}

        //public IActionResult Index()
        //{
        //    var data = ItemMenuRepository.View().ToListViewModel();

        //    foreach (var item in data)
        //    {
        //        if (item.MasterCategoryMenuId != null)
        //        {
        //            // Assuming the Find method accepts a nullable type or checks for null internally
        //            var categoryMenu = CategoryMenuRepository.Find(item.MasterCategoryMenuId.Value);

        //            if (categoryMenu != null)
        //            {
        //                item.MasterCategoryMenu = categoryMenu;
        //            }
        //            else
        //            {
        //                // Handle the case where no matching category menu is found
        //                item.MasterCategoryMenu = null; // or some default value
        //            }
        //        }
        //        else
        //        {
        //            // Handle cases where MasterCategoryMenuId is null
        //            item.MasterCategoryMenu = null; // or some default value
        //        }
        //    }
        //    return View(data);
        //}








    }
}

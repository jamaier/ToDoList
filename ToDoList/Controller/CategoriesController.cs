using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;

namespace ToDoList.Controllers
{
  public class CategoriesController : Controller
  {
    [HttpGet("/categories")]
    public ActionResult Index()
    {
      List<Category> allCategories = Category.GetAll();
      return View(allCategories);
    }

    [HttpGet("/categories/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/categories")]
    public ActionResult Create(string categoryName)
    {
      Category newCategory = new Category(categoryName);
      return RedirectToAction("Index");
    }

    [HttpGet("/categories/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Category selectedCategory = Category.Find(id);
      List<Item> categoryItems = selectedCategory.Items;
      model.Add("category", selectedCategory);
      model.Add("items", categoryItems);
      return View(model);
    }

    // This one creates new Items within a given Category, not new Categories:
    [HttpPost("/categories/{categoryId}/items")]
    public ActionResult Create(int categoryId, string itemDescription)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Category foundCategory = Category.Find(categoryId);
      Item newItem = new Item(itemDescription);
      foundCategory.AddItem(newItem);
      List<Item> categoryItems = foundCategory.Items;
      model.Add("items", categoryItems);
      model.Add("category", foundCategory);
      return View("Show", model);
    }

    [HttpPost("/categories/{categoryId}/items/{itemId}/delete")]

    //should be a model method probably
    public ActionResult Delete(int categoryId, int itemId)
    {
      Category selectedCategory = Category.Find(categoryId);
      Item selectedCategoryItem = selectedCategory.Items.Find(item => item.Id == itemId);

      foreach (Item item in selectedCategory.Items)
      {
        if (item.Id == itemId)
        {
          selectedCategory.Items.Remove(item);
          break;
        }
      }

      return RedirectToAction("Show", new { id = categoryId });
    }

    // public ActionResult DeleteAll(int categoryId)
    // {
    // // Item.ClearAll();
    // Category selectedCategory = Category.Find(categoryId);
    // List<Item> categoryItems = selectedCategory.Items;
    // categoryItems.Clear();

    // Dictionary<string, object> model = new Dictionary<string, object>();
    // model.Remove("category");
    // model.Remove("item");

    // return View(model);
    // model.Clear("category", selectedCategory); // categoryItems
    // return View();
    // }

    // var item = myList.Find(x => x.ItemName == obj.ItemName);
    // myList.Remove(item);
  }
}
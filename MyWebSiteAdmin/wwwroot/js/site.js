// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


// Veritabanı referansını al
var database = firebase.database();

// Buton elementini seç
var addButton = document.getElementById("addButton");

// Butona tıklanınca çalışacak fonksiyon
addButton.addEventListener("click", function() {
  // Örnek blog verisi
  var blogData = {
    title: "Yeni Blog Başlığı",
    content: "Bu yeni bir blog içeriğidir."
  };

  // Yeni bir blog eklemek için 'blogs' tablosuna bir referans oluştur
  var newBlogRef = database.ref('blogs').push();

  // Blog verisini ekleyerek veritabanına gönder
  newBlogRef.set(blogData)
    .then(function() {
      console.log("Blog başarıyla eklendi.");
    })
    .catch(function(error) {
      console.error("Blog eklenirken bir hata oluştu: ", error);
    });
});
let list=document.getElementById("list")
axios("//api.tvmaze.com/shows")
.then(res=>{
    // console.log(res.data);
      res.data.forEach(element => {
       list.innerHTML+=`
       <div class="col-3 col-sm-6 col-md-6 col-lg-6 col-xl-4 col-xxl-3" style="padding:16px; max-height:710px">
       <div class="card" style="width: 100%;">
       <img class="card-img-top" src="${element.image.medium}" alt="Card image cap">
       <div class="card-body">
         <h3 class="card-title">${element.name}</h3>
       
         <div class="d-flex align-items-center gap-3 fs-4 mb-2">
         <i class="fa-solid fa-star text-warning"></i>
         <p class="card-text">${element.rating.average}</p>
         </div>
         <a href="${element.url}" class="btn btn-primary">Go film site</a>
       </div>
     </div>
       </div>
       `
    });
})

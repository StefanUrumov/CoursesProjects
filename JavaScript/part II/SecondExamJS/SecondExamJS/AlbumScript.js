function tryMe() {
    //I know that MUST be done by using inheritance, constructors and etc., but this is my best
	//I've worked mostly on task 1 and 2
    
    //task 1
    function controlsObj() { };
    controlsObj.prototype.getImageGallery = getImageGallery;
    controlsObj.prototype.addImage = addImage;
    controlsObj.prototype.addAlbum = addAlbum;
    controlsObj.prototype.addInnerAlbum = addInnerAlbum;
    var gallery = new controlsObj();

    function getImageGallery(albumName) { 
        this.galleryName = albumName;
        album = document.getElementById(this.galleryName);
    };

    function addImage(imageName, imagePath) { //extend(addImage, getImageGallery, this);
        //var album = document.getElementById('imageAlbumHolder');
        //var album = document.getElementById(album);
        this.imgName = document.createTextNode(imageName);
        this.imgPath = imagePath;
        var imageDiv = document.createElement('Div');
        var img = document.createElement('img');        
        img.src = this.imgPath;
        img.setAttribute("height", "70");
        img.setAttribute("width", "70");
        img.style.display = 'block';
        imageDiv.style.border = '1px solid black';
        imageDiv.style.width = '71px';
        imageDiv.style.height = '100px';
        imageDiv.style.borderRadius = '10px';
        imageDiv.style.marginTop = '20px';
        imageDiv.style.marginLeft = '20px';
        imageDiv.style.display = 'inline-block';
        imageDiv.style.textAlign = 'center';
        imageDiv.appendChild(this.imgName);
        imageDiv.appendChild(img);
        album.appendChild(imageDiv);
        //this.album.appendChild(imageDiv);
    }
    
    
    function addAlbum(albumName) {
        
        var currentAlbum = document.createElement('Div');
        var textDiv = document.createElement('Div');
        this.albName = document.createTextNode(albumName);
               
        currentAlbum.style.border = '1px solid black';
        currentAlbum.style.width = '330px';
        currentAlbum.style.height = "320px";
        currentAlbum.borderRadius = '10px';
        currentAlbum.style.marginTop = '10px';
        currentAlbum.style.borderRadius = '10px';
        currentAlbum.style.textAlign = 'center';

        textDiv.appendChild(this.albName);
        currentAlbum.appendChild(textDiv);
        album.appendChild(currentAlbum);

        album = currentAlbum;
    }
   

    //task 2
    function addInnerAlbum(selectedAlbum) {
        this.albInnerName = document.createTextNode(selectedAlbum);
        var currentAlbum = document.createElement('Div');
        var textInnerDiv = document.createElement('Div');

        currentAlbum.style.border = '1px solid black';
        currentAlbum.style.width = '300px';
        currentAlbum.style.height = "150px";
        currentAlbum.borderRadius = '10px';
        currentAlbum.style.marginTop = '10px';
        currentAlbum.style.marginLeft = '10px';
        currentAlbum.style.borderRadius = '10px';
        currentAlbum.style.textAlign = 'center';

        textInnerDiv.appendChild(this.albInnerName);
        currentAlbum.appendChild(textInnerDiv);
        album.appendChild(currentAlbum);

        album = currentAlbum;
    }

    //task 3   
    function hideMe(album) {
       //var ninjaDivs = document.getElementById(album);              
      //ninjaDivs.style.display = 'none';
       album.style.display = 'none';
        
    }

    function showMe(album) {
        //var ninjaDivs = document.getElementById(album);
        //ninjaDivs.style.display = 'block';
        album.style.display = 'block';
    }


        gallery.getImageGallery('imageAlbumHolder');
        gallery.addImage('JS Ninja', 'images/image.png');
        gallery.addImage('JS Ninja', 'images/image.png');
        gallery.addImage('JS Ninja', 'images/image.png');

        gallery.addAlbum('Ninjas');
        gallery.addImage('JS Ninja 2', 'images/image.png');
        gallery.addImage('JS Ninja 2', 'images/image.png');
        gallery.addImage('JS Ninja 2', 'images/image.png');

        gallery.addInnerAlbum('Kids Ninjas');
        gallery.addImage('Kid Ninja', 'images/image.png');
        gallery.addImage('Kid Ninja', 'images/image.png');
};


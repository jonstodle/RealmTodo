var currentSlide = 0;

function handleBodyLoad() {
    setContentSize();
    updateSlidesDisplay();
}

function handleBodyResize() {
    setContentSize();
}

function handleBodyKeyDown(ev) {
    if(ev.key === "ArrowRight") currentSlide++;
    else if(ev.key === "ArrowLeft") currentSlide--;
    updateSlidesDisplay();
}

function setContentSize(padding){
    let contentPadding = 10;
    
    if(!!padding) contentPadding = padding;
    
    const content = document.getElementById("content");
    content.style.padding = contentPadding + "px";
    content.style.height = document.documentElement.clientHeight - (contentPadding * 2);
    content.style.width = document.documentElement.clientWidth - (contentPadding * 2);

    document.documentElement.style.fontSize = (content.clientHeight * .03) + "px";
}

function updateSlidesDisplay() {
    const slides = document.getElementsByClassName("slide");

    if(currentSlide < 0) currentSlide = slides.length -1;
    else if(currentSlide >= slides.length) currentSlide = 0;

    for(var i = 0; i < slides.length; i++){
        slides[i].style.display = i === currentSlide ? "flex" : "none";
    }
}
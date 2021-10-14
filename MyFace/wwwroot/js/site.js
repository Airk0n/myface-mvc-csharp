var imgs = ["/images/bes.png", "/images/brig.png","/images/jord.png","/images/rich.png","/images/tem.png",]
window.addEventListener("load", function () {
    var allPosts = document.getElementsByClassName("post");
    for (let i = 0; i < allPosts.length; i++)
    {
        allPosts[i].addEventListener("click", function(){ postClicked(allPosts[i]); });
        allPosts[i].querySelector(".editPostText").addEventListener('click', ()=> ShowModal(allPosts[i].id))
    }
});

var currPost = null;
let ruined = false;

function getPostMessage(post) {
    const c = post.children;
    let i;
    for (i = 0; i < c.length; i++) {
        if (c[i].className === "message") {
            return c[i];
        }
    }
}

function displayEditButton(post, whatDoYouWant) {
    const c = post.children;
    let i;
    for (i = 0; i < c.length; i++) {
        if (c[i].className === "editPostText") {
            c[i].style.display = whatDoYouWant ? "block" : "none";
        }
    }
   
}

function disablePost(post)
{
    let postMessage = getPostMessage(post);
    displayEditButton(post, false)

    post.style.backgroundColor = "#333";
    postMessage.style.fontSize = "20px";
}

function ShowModal(id, whatDoYouWant=true){
    const MyVeryOwnModal = document.getElementById("CharlesModal");
    MyVeryOwnModal.style.display = whatDoYouWant ? "block" : "none";
    MyVeryOwnModal.postid = id
}

function RemovePost(post){
    document.getElementById(post).style.display = "none";
    ShowModal(null, false)
}

function RuinBensDay(post){
    alert("You fooooooooooooooooooooooooool!!!!")
    RemovePost(post);
    let EwaAsBen = new Audio('/sounds/Woops.m4a');

    document.body.style.backgroundRepeat = "repeat-y"
    document.body.style.backgroundSize = "100%"
    document.body.style.backgroundImage = "url('https://media-exp1.licdn.com/dms/image/C4D03AQF7C5KzdUFLcg/profile-displayphoto-shrink_800_800/0/1562106459334?e=1639612800&v=beta&t=7NqH2EZyTry0de4o9_1UqV5YVi_GOV6smcvpXiDCSb4')";

    EwaAsBen.play();
    
    if (ruined)
    {
        var allPosts = document.getElementsByClassName("post");
        for (let i = 0; i < allPosts.length; i++)
        {
            allPosts[i].style.backgroundSize = "100%"
            allPosts[i].style.backgroundImage = "url(" + imgs[getRandomInt(0, 5)]  + ")";
        }
    }

    ruined = true;
}

function enablePost(post)
{
    let postMessage = getPostMessage(post);
    displayEditButton(post, true)
    post.style.backgroundColor = "rgb(255,0,0)"
    postMessage.style.fontSize = "large"
}

function postClicked(post) {
    if (currPost === post)
    {
        disablePost(post);
        currPost = null;
    }
    else
    {
        enablePost(post);
        
        if (currPost != null)
        {
            disablePost(currPost);
        }
        
        currPost = post;
    }
}

function getRandomInt(min, max) {
    min = Math.ceil(min);
    max = Math.floor(max);
    return Math.floor(Math.random() * (max - min) + min); //The maximum is exclusive and the minimum is inclusive
}
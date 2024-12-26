<script>
    import '@fontsource-variable/source-code-pro';
    import '@fontsource/gugi';
</script>

<style>
.body {
    background-color: white;
    margin: 0;
    padding: 0;
    min-height: 100vh;
}

.header {
    background-image: url('/src/lib/assets/about/header0.jpg');
    background-size: cover;
    background-repeat: no-repeat;
    background-position: 50% 85%;
    text-align: center;
    padding: 40px;
    color: white;
    height: 475px;
}

.header h1 {
    font-family: 'Orbitron Variable', sans-serif;
    padding: 20px;
    font-size: 3rem;
    margin: 10px 0;
    z-index: 1;
    text-shadow: 2px 2px 4px rgba(0, 0, 0, 0.5); 
}

.header h2 {
    font-family: 'Exo 2 Variable';
    padding: 20px;
    font-size: 1.5rem;
    margin: 10px 0;
    z-index: 1;
    text-shadow: 2px 2px 4px rgba(0, 0, 0, 0.5); 
}

.buttons {
    display: flex;
    justify-content: center;
    padding: 20px;
    margin: 20px auto;
}

.button {
    padding: 10px 20px;
    font-size: 2vh;
    font-family: 'Exo 2 Variable';
    margin: 0 10px;
    background-color: #111111;
    color: #ffffff;
    border: none;
    border-radius: 5px;
    transition: all 0.3s ease;
    cursor: pointer;
}

.button:hover {
    filter: invert(1);
    transform: scale(1.05);
}

.content-row {
    padding: 20px;
    background-color: #ffffff;
    color: #000000;
    border-top: 1px solid rgb(255, 255, 255);
    margin: 10px auto;
}

.container {
    background-color: #f1f1f1;
    border-radius: 10px;
    padding: 20px;
    margin: 10px auto;
}

.content-row h1 {
    font-family: 'Orbitron Variable', sans-serif;
    font-size: 3vh;
    color: #000000;
    text-align: center;
    margin: 10px auto;
}

.content-row p {
    font-family: 'Exo 2 Variable';
    font-size: 2vh;
    text-align: center;
    color: #000000;
    line-height: 1.6;
    padding: 20px;
    margin: 10px auto;
}

.separator {
    content: "";
    display: block;
    height: 2px;
    background-color: black;
    border-radius: 1px; 
    width: 80%; 
    margin: 20px auto;
}

.item-rowcontainer {
    display: flex;
    justify-content: center;
    width: 40%;
    margin: 10px auto;
    
}

.item-container {
    flex: 0 0 60%; 
    text-align: center;
    background-color: #f1f1f1;
    border-radius: 10px;
    padding: 20px;
    margin: 10px auto;
    transition: all 0.3s ease;
    cursor: pointer;
}

.item-container:hover {
    transform: scale(1.05);
    filter: invert(1);
}

.item-container img {
    width: 18vh;
    height: auto;
}

.item-container p {
    font-family: 'Orbitron Variable', sans-serif;
    font-size: 2vh;
    text-align: center;
    color: #000000;
    line-height: 1.6;
    padding: 20px;
    font-weight: bold;
    margin: 10px auto;
}

.vseparator::after {
    content: "";
    height: 100%; 
    margin-left: 2vw;
    margin-right: 2vw;
    color: white;
}

@media (max-width: 768px) {

.header {
    background-position: 50% 50%;
    height: 350px;
}

.header h1 {
    padding: 10px;
    margin: 15px auto;
}

.header h2 {
    padding: 10px;
    margin: 5px auto;
}

.buttons {
    padding: 10px;
    margin: 5px auto;
}

.button {
    padding: 10px 20px;
    font-size: 2vh;
    font-family: 'Exo 2 Variable';
    margin: 0 auto;
}

.item-rowcontainer {
    overflow-x: auto;
    width: auto;
    display: inline;
    padding: 20px;
}

.item-container {
    flex: 0 0 auto; 
    min-width: 30%; 
}


}
</style>

<div class="body">
<div class="header">
<h1>About us</h1>
<h2>A UOL student-run engineering society based in the Electrical and Electronics Engineering department</h2>
</div>
<div class="content-row">
<div class="container">
<h1>What is LASER?</h1>
<div class="separator"></div>
<p>LASER is a student-run Engineering society based in the Electrical and Electronics Engineering department. We run multiple projects that span a broad range of fields and welcome new people to join at all times. All backgrounds and courses are welcome - even people who aren't interested in the technical side.
    Some of our current initiatives include an entry into the UKSEDS rocketry competition, microcontroller/personal project workshops, visits to engineering companies, and talks from experts in the industry.
    We want to create a friendly and social atmosphere where students can not only develop their engineering and management skills, but also gain important industrial skills that students don’t tend to learn during their time in University.</p>
</div>
</div>
<div class="content-row">
<h1>Our 2024/25 Committee:</h1>
<p>Members who are selected to run and organise LASER for the 2024/25 academic year.</p>
<div class="separator"></div>
</div>
<div class="content-row">
<div class="container">
    <h1>Our Funding sources:</h1>
    <p>We would like to thank the following for providing financial support to LASER.</p>
    <div class="separator"></div>
    <p>We would like to acknowledge the generous financial support we have recieved, which has been instrumental in enabling us to run various projects and the purchase of equipment for our lab space. This has been made possible through the funding provided by the <strong>Moruzzi Fund</strong> and the <strong>University of Liverpool's Electrical Engineering and Electronics department</strong>.</p>
</div>
</div>
</div>

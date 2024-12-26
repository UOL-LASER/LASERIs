<!--Index.svelte-->
<script>
    import '@fontsource-variable/source-code-pro';
    import '@fontsource/gugi';

    import profilepicture from '$lib/assets/icons/email.svg';
    import netrmsilogo from '$lib/assets/netrmsi.png'
    import infecteddepthslogo from '$lib/assets/infecteddepths.png'
    import mail from '$lib/assets/mail.png'
    import logo from '$lib/assets/logo.svg'
    import favicon from '$lib/assets/logo.svg'
    import gamejolt from '$lib/assets/gamejolt.svg'
    import maillobbyer from '$lib/assets/maillobbyer.svg'
    import laser from '$lib/assets/laser.png'
</script>

<style>
    .body {
      margin: 0;
      padding: 0;
      min-height: 100vh;
    }

    .container {
      font-family: 'Source Code Pro Variable', monospace;
      max-width: 1200px;
      margin: 0 auto;
      padding: 110px;
      color: white;
      display: grid;
      grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
      gap: 20px;
    }

    .section {
      text-align: center;
      background: rgba(0, 0, 0, 0.6);
      padding: 20px;
      border-radius: 5px;
      box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
    }

    .section h2 {
      font-family: 'Gugi', system-ui;        
      margin: 0 0 20px;
      font-size: 24px;
      color: #ffffff;
    }

    .userinfo img.profilepicture {
      width: 150px;
      height: 150px;
      border-radius: 50%;
      border: 3px solid #ffffff;
      margin: 10px;
    }

    .userinfo p {
      margin: 10px 0;
    }

    .userinfo .name {
      font-family: 'Gugi', system-ui;        
      margin: 20px 0 10px;
      font-size: 20px;
      color: #ffffff;
    }

    .userinfo .about {
      text-align: justify;
    }

    .userinfo h3 {
      font-family: 'Gugi', system-ui;        
      margin: 20px 0 10px;
      font-size: 20px;
      color: #ffffff;
    }

    .languages-list, .contacts-list {
      list-style-type: none;
      padding: 0;
      display: flex;
      flex-wrap: wrap;
      justify-content: center;
      gap: 10px;
    }

    .languages-list li img, .contacts-list li img {
      width: 50px;
      height: 50px;
    }

    .portfolio {
      display: grid; 
      grid-template-columns: repeat(auto-fill, minmax(200px, 1fr)); /* Allow columns to grow horizontally */
      gap: 20px; 
      justify-content: center;
    }

    .portfolio .item {
      padding: 20px;
      border-radius: 10px;
      text-align: center;
      transition: transform 0.3s ease, box-shadow 0.3s ease;
    }

    .portfolio .item a {
      text-decoration: none;
    }

    .portfolio .item:hover {
      transform: translateY(-10px);
    }

    .portfolio .item img {
      margin-bottom: 10px;
      max-width: 80px;
      max-height: 80px;
    }

    .portfolio .item h3 {
      font-family: 'Gugi', system-ui;        
      margin: 10px 0 10px;
      font-size: 18px;
      color: #ffffff;
    }

    .portfolio .item p {
      margin: 0;
      font-size: 14px;
      color: #ffffff;
    }

    @media (max-width: 768px) {
      .container {
        grid-template-columns: 1fr;
      }
      .portfolio {
        grid-template-columns: 1fr;
      } 
    }
</style>

<div class="body">
    <div class="container">
        <section class="section">
        <h2>About Me</h2>
        <div class="userinfo">
            <img class="profilepicture" src={profilepicture} alt="Profile Picture">
            <p class="name">Peter Hamilton</p>
            <p class="about">Computer Science student
              at UOL | Self-taught
              programmer with
              experience in C, .NET,
              C/C++, Python, Java, and
              more | Enthusiastic about
              full-stack development,
              machine learning, and
              game development |
              Proficient in Linux and
              adept at version control
              with Git | Passionate about
              software development,
              particularly in open-source
              projects and developing
              skills related to DevOps
              and SysAdmin tasks |
              Currently learning Sveltekit
              and Rust along with
              staying updated on and
              learning more about new
              technologies along with
              ones I already work with.</p>
            <h3>Languages and Tools</h3>
            <ul class="languages-list">
            <li><img src="https://www.vectorlogo.zone/logos/gnu_bash/gnu_bash-icon.svg" alt="Bash" title="Bash"></li>
            <li><img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/c/c-original.svg" alt="C" title="C"></li>
            <li><img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/cplusplus/cplusplus-original.svg" alt="C++" title="C++"></li>
            <li><img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/csharp/csharp-original.svg" alt="C#" title="C#"></li>
            <li><img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/css3/css3-original-wordmark.svg" alt="CSS" title="CSS"></li>
            <li><img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/docker/docker-original-wordmark.svg" alt="Docker" title="Docker"></li>
            <li><img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/dot-net/dot-net-original-wordmark.svg" alt=".NET" title=".NET"></li>
            <li><img src="https://www.vectorlogo.zone/logos/git-scm/git-scm-icon.svg" alt="Git" title="Git"></li>
            <li><img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/html5/html5-original-wordmark.svg" alt="HTML" title="HTML"></li>
            <li><img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/java/java-original.svg" alt="Java" title="Java"></li>
            <li><img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/javascript/javascript-original.svg" alt="JavaScript" title="JavaScript"></li>
            <li><img src="https://upload.wikimedia.org/wikipedia/commons/1/13/Arch_Linux_%22Crystal%22_icon.svg" alt="Arch Linux" title="Arch Linux"></li>
            <li><img src="https://www.vectorlogo.zone/logos/mariadb/mariadb-icon.svg" alt="MariaDB" title="MariaDB"></li>
            <li><img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/mysql/mysql-original-wordmark.svg" alt="MySQL" title="MySQL"></li>
            <li><img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/mongodb/mongodb-original.svg" alt="MongoDB" title="MongoDB"></li>
            <li><img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/nginx/nginx-original.svg" alt="Nginx" title="Nginx"></li>
            <li><img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/php/php-original.svg" alt="PHP" title="PHP"></li>
            <li><img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/python/python-original.svg" alt="Python" title="Python"></li>
            <li><img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/raspberrypi/raspberrypi-original.svg" alt="Raspberry Pi" title="Raspberry Pi"></li>
            <li><img src="https://www.vectorlogo.zone/logos/godotengine/godotengine-icon.svg" alt="Godot Engine" title="Godot Engine"></li>
            <li><img src="https://www.vectorlogo.zone/logos/unity3d/unity3d-icon.svg" alt="Unity" title="Unity"></li>
            <li><img style="filter: invert();" src="https://raw.githubusercontent.com/rust-lang/rust-artwork/master/logo/rust-logo-blk.svg" alt="Rust" title="Rust"></li>
            <li><img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/svelte/svelte-original.svg" alt="Svelte" title="Svelte"></li>
            </ul>
        </div>
        </section>
        <section class="section">
        <h2>Portfolio</h2>
        <div class="portfolio">
            <div class="item">
            <a href="/projects/mailLobbyer" rel="prefetch">
            <img src="{maillobbyer}" alt="MailLobbyer Icon">
            <h3>MailLobbyer</h3>
            <p>Built with ASP.NET Core Blazor and Electron.NET, a batch CSV-based emailing solution with SMTP server integration.</p>
            </a>
            </div>
            <div class="item">
            <img src="{infecteddepthslogo}" alt="Infected Depths Icon">
            <h3>Infected Depths</h3>
            <p>A work in progess top-down 2D rogue-like shooter built in the Godot engine.</p>
            </div>
            <div class="item">
            <img src="{laser}" alt="LASER Icon">
            <h3>LASER Safety Compliance Service</h3>
            <p>A safety compliance program that monitors LASER's lab space.</p>
            </div>
            <div class="item">
            <img src="{laser}" alt="LASER Icon">
            <h3>LASER Website</h3>
            <p>A website built with SvelteKit.</p>
            </div>
            <div class="item">
            <img src={netrmsilogo} alt="NET-RMSI LOGO">
            <h3>NET-RMSI</h3>
            <p>An open-source networked remote management server interface.</p>
            </div>
        </div>
        </section>
    </div>
</div>


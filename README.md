<!-- Improved compatibility of back to top link: See: https://github.com/othneildrew/Best-README-Template/pull/73 -->
<a name="readme-top"></a>






[![LinkedIn][linkedin-shield]][linkedin-url]



<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://github.com/Audacity01/AracanBlogWebsiteTask">
    <img src="https://res.cloudinary.com/dtkvxnzbk/image/upload/v1711301161/nzwz9ihfnl2dmy5qgbtz.jpg" alt="Logo" width="80" height="80">
  </a>

<h3 align="center">Aracan Blogging Website</h3>

  <p align="center">
    A simple blogging project utilizing .NET MVC 
    <br />
</a>
    <br />
    <br />
    <a href="https://github.com/Audacity01/AracanBlogWebsiteTask">View Demo</a>
    ·
    <a href="https://github.com/Audacity01/AracanBlogWebsiteTask/issues">Report Bug</a>
    ·
    <a href="https://github.com/Audacity01/AracanBlogWebsiteTask/issues">Request Feature</a>
  </p>
</div>



<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgments">Acknowledgments</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project

![Product Name Screen Shot][product-screenshot]

Embark on a streamlined journey with our sleek blogging platform! Crafted with precision using .NET 8 and MVC architecture, my creation offers seamless features like *image uploading, identity authentication*, and more. Dive into a world where users can effortlessly *browse, create, edit, and delete blog posts*, complete with an interactive *comment and like system*. With its responsive design and savvy use of *Entity Framework*, this project is your gateway to blogging excellence!


<p align="right">(<a href="#readme-top">back to top</a>)</p>



### Built With

* .NET 8
* Bootstrap
* Javascript
* Cloudinary for image uploading
* Froala for text editing.
* MS Sql Server (hosted in azure)

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- GETTING STARTED -->
## Getting Started


To get a local copy up and running follow these simple example steps.

### Prerequisites

This is an example of how to list things you need to use the software and how to install them.
* .NET 8
  ```sh
  visual studio installer -> individual components -> .NET 8 Runtime
  ```

### Installation


1. Clone the repo
   ```sh
   git clone https://github.com/Audacity01/AracanBlogWebsiteTask.git
   ```
2. Open the .sln file and run the https. Connection strings are hard coded in  appsettings.json. (Will remove them later)
3. Remember the Super Admin ID and Pass which are required when log in - 
    ```sh
    ID - superadmin@blog.com
    PASS - Superadmin@123
    ```



<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- USAGE EXAMPLES -->
## Usage

Dive into simplicity with a twist! My project combines a minimalist aesthetic with intricate designs and seamless integration of powerhouse libraries like Cloudinary and Froala. Whether you're launching a basic blogging platform or craving customization, this project has you covered. It's a go-to reference for students and newcomers delving into the world of .NET MVC!


<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- ROADMAP -->
## Roadmap

- [ ] Create, edit or delete your blogs
- [ ] Identity based Authentication
    - [ ] Super Admin - to create or delete Admins & Users
    - [ ] Admin - they can create, edit or delete their own blogs
    - [ ] User - they can register and only view blogs
- [ ] Tags - Admin can create customized tags and use them into their blogs
- [ ] Comment - Register users can add comments to the blog
- [ ] Likes - Regsiter user can like the blogs (with minor bug - cannot unlike them)
- [ ] Image saving system - Images are directly saved to the cloud via Cloudinary.
- [ ] Powerful Text Editor - Implemented Froala CDN.



<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

If you have a suggestion that would make this better, please fork the repo and create a pull request. You can also simply open an issue with the tag "enhancement".
Don't forget to give the project a star! Thanks again!

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

<p align="right">(<a href="#readme-top">back to top</a>)</p>




<!-- CONTACT -->
## Contact

Name - [Vaibhav Joshi](https://twitter.com/Fsociety_vj) - email: vaibjo.2001@gmail.com.com

Project Link: [https://github.com/Audacity01/AracanBlogWebsiteTask](https://github.com/Audacity01/AracanBlogWebsiteTask)

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- ACKNOWLEDGMENTS -->
## Acknowledgments
I am deeply grateful to Aracan for granting me the opportunity to embark on this remarkable project, which demanded extensive planning and dedication. Below, I share some of the websites and tutorials that were instrumental in guiding me through its completion.

* [Sameer Raina's Youtube Guide](https://www.youtube.com/watch?v=jhj9ouy7x1g&t=3461s)
* [MVC Tutorials](https://www.javatpoint.com/asp-net-mvc)
* And thanks to my friends that helped me out.

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/Audacity01/AracanBlogWebsiteTask.svg?style=for-the-badge
[contributors-url]: https://github.com/Audacity01/AracanBlogWebsiteTask/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/Audacity01/AracanBlogWebsiteTask.svg?style=for-the-badge
[forks-url]: https://github.com/Audacity01/AracanBlogWebsiteTask/network/members
[stars-shield]: https://img.shields.io/github/stars/Audacity01/AracanBlogWebsiteTask.svg?style=for-the-badge
[stars-url]: https://github.com/Audacity01/AracanBlogWebsiteTask/stargazers
[issues-shield]: https://img.shields.io/github/issues/Audacity01/AracanBlogWebsiteTask.svg?style=for-the-badge
[issues-url]: https://github.com/Audacity01/AracanBlogWebsiteTask/issues
[license-shield]: https://img.shields.io/github/license/Audacity01/AracanBlogWebsiteTask.svg?style=for-the-badge
[license-url]: https://github.com/Audacity01/AracanBlogWebsiteTask/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://www.linkedin.com/in/vaibhav-joshi-363881241/
[product-screenshot]: https://res.cloudinary.com/dtkvxnzbk/image/upload/v1711301792/gbstkzlemijddcmb1ubt.jpg
[Next.js]: https://img.shields.io/badge/next.js-000000?style=for-the-badge&logo=nextdotjs&logoColor=white
[Next-url]: https://nextjs.org/
[React.js]: https://img.shields.io/badge/React-20232A?style=for-the-badge&logo=react&logoColor=61DAFB
[React-url]: https://upload.wikimedia.org/wikipedia/commons/7/7d/Microsoft_.NET_logo.svg
[Vue.js]: https://img.shields.io/badge/Vue.js-35495E?style=for-the-badge&logo=vuedotjs&logoColor=4FC08D
[Vue-url]: https://vuejs.org/
[Angular.io]: https://img.shields.io/badge/Angular-DD0031?style=for-the-badge&logo=angular&logoColor=white
[Angular-url]: https://angular.io/
[Svelte.dev]: https://img.shields.io/badge/Svelte-4A4A55?style=for-the-badge&logo=svelte&logoColor=FF3E00
[Svelte-url]: https://svelte.dev/
[Laravel.com]: https://img.shields.io/badge/Laravel-FF2D20?style=for-the-badge&logo=laravel&logoColor=white
[Laravel-url]: https://laravel.com
[Bootstrap.com]: https://img.shields.io/badge/Bootstrap-563D7C?style=for-the-badge&logo=bootstrap&logoColor=white
[Bootstrap-url]: https://getbootstrap.com
[JQuery.com]: https://img.shields.io/badge/jQuery-0769AD?style=for-the-badge&logo=jquery&logoColor=white
[JQuery-url]: https://jquery.com 

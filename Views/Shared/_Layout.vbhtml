<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Netflux - Homepage</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
</head>
<body>
    <div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                @Html.ActionLink("Netflux", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    <li>@Html.ActionLink("Browse", "Index", "Home")</li>
                    <li>@Html.ActionLink("Popular", "Index", "Home")</li>
                    <li>@Html.ActionLink("Kids", "Index", "Home")</li>
                </ul>
                <div class="wrapper">
                    <div class="search-input">
                        <a href="" target="_blank" hidden></a>
                        <input type="text" placeholder="Type to search..">
                        <div class="autocom-box">
                            <!-- here list are inserted from javascript -->
                        </div>
                        <div class="icon"><i class="fas fa-search"></i></div>
                    </div>
                </div>
            </div>

        </div>
    </div>

    <div class="container body-content">
        @RenderBody()
        <hr />
        <footer>
            <p>&copy; 2021 Netflux</p>
        </footer>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
    <script src="~/Scripts/DVDs.js"></script>
    <script src="~/Scripts/searchScript.js"></script>

</body>
</html>

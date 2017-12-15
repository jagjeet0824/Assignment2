@ModelType ass1.Games2
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>Games2</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Awards)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Awards)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Vocal)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Vocal)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Onstage)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Onstage)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>

# UI v5 - the design now lives in the Visual Studio Designer

Every page is a normal designer-built form again: open `Form1.cs`, `LoginPage.cs`, `Individual.cs`, `Organization.cs`,
`Apply.cs`, `Donor.cs`, `Application.cs`, `DonateMoney.cs` or `Admin.cs` in Visual Studio and you get the design surface.
All the layout, fonts, colours and hover effects are in the matching `*.Designer.cs`; there is no `BuildUi()` code any more.

## First time you open it
1. Open `Project.csproj`, then **Build > Rebuild Solution** once. The custom controls (below) must be built before the
   designer can draw the pages.
2. Then double-click any form. The custom controls appear in the Toolbox under "Project Components".

## Reusable controls (so pages stay short and consistent)
- `HintBox` - text box with a `Hint` property (grey placeholder text). Replaces the old runtime cue-banner calls.
- `CardPanel` - white card with a coloured top strip (`Accent` property).
- `StatCard` - big number + caption (`Value`, `Caption`, `Accent`).
- `TopBar` - navy bar for logged-in pages (shows who is signed in, Log out button).
- `BrandPanel` - navy panel on the sign-in / registration cards (`Headline`, `Bullet1..3`).
- `CoverPanel` - background photo with tint; `NumberBadge`; `ScrollPage` (home page scrolling).
- `PageForm` - base class of every page: quits the app when a page is really closed, and `GoTo(form)` replaces the
  old "Hide(); new X().Show();" pairs.
All of these are in `Controls.cs`, `PageForm.cs` and the small `BrandPanel` / `StatCard` / `TopBar` user controls.

## Code that was removed
`Theme.cs`, `Sections.cs` (all runtime layout code), the `FormGrid` helper, every `BuildUi()`, and empty handlers
(`Individual_Load`, `LoginPage_Load`, `dateTimePicker1_ValueChanged`, `txtPass_TextChanged`, `txtRegnum_TextChanged`,
`btnApply_Click`, the unused radio handlers on the home page). Sample text that used to live in `SiteContent`
(stats, most-needed items, contact details, bank details) is now plain text in the designer: edit it there.
`Dash.cs` shrank to a few data helpers.

## What still happens in code (because it is data, not design)
- Names and dates (`Welcome back, <name>`, best-before date, current year in footers).
- The Admin list columns change per section, so they are set in `Admin.cs`.
- Everything from v3/v4: validation (`Rules.cs`), text-file storage (`DataStore.cs`), money pledges, admin actions.

## Small visual differences from v4
- Nav and footer links are `LinkLabel`s (underline on hover; colour change on click) instead of custom hover labels.
- The quick-amount buttons (Donate money) and the section tabs (Admin) are toggle buttons; the selected one is
  shaded light orange.
- Cell number box is limited to 10 digits and its hint is `0821234567` (matches the validation).
- Province list uses the spelling "KwaZulu-Natal".

## Admin login (unchanged)
`admin@fooddonation.local` / `Admin@123`, created on first run. Change it in `Application.txt` (row starting with `Admin`).

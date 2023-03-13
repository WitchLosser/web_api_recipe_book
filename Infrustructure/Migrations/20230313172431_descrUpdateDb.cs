using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.Migrations
{
    public partial class descrUpdateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "step1",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "step10",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "step11",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "step12",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "step13",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "step14",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "step15",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "step2",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "step3",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "step4",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "step5",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "step6",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "step7",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "step8",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "step9",
                table: "Recipes");

            migrationBuilder.CreateTable(
                name: "DescriptionSteps",
                columns: table => new
                {
                    StepId = table.Column<int>(type: "int", nullable: false),
                    RecipeId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DescriptionSteps", x => new { x.StepId, x.RecipeId });
                    table.ForeignKey(
                        name: "FK_DescriptionSteps_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DescriptionSteps",
                columns: new[] { "RecipeId", "StepId", "Description" },
                values: new object[,]
                {
                    { 1, 1, "Put a large saucepan of water on to boil." },
                    { 2, 1, "Season the beaten eggs well with salt and pepper. Heat the oil and butter in a non-stick frying pan over a medium-low heat until the butter has melted and is foaming." },
                    { 3, 1, "Remove the beef from the fridge 30 minutes before you want to cook it, to let it come up to room temperature." },
                    { 4, 1, "Pre-heat the oven to 200ºC/400ºF and line a sheet pan with parchment/baking paper." },
                    { 1, 2, "Finely chop the 100g pancetta, having first removed any rind. Finely grate 50g pecorino cheese and 50g parmesan and mix them together." },
                    { 2, 2, "Pour the eggs into the pan, tilt the pan ever so slightly from one side to another to allow the eggs to swirl and cover the surface of the pan completely. Let the mixture cook for about 20 seconds then scrape a line through the middle with a spatula." },
                    { 3, 2, "Preheat the oven to 240°C/475°F/ gas 9." },
                    { 4, 2, "Combine the butter, lemon, garlic and herbs in a saucepan and bring to a simmer. Cook for 2-3 minutes until fragrant then remove from the heat and set aside to cool slightly." },
                    { 1, 3, "Beat the 3 large eggs in a medium bowl and season with a little freshly grated black pepper. Set everything aside." },
                    { 2, 3, "Tilt the pan again to allow it to fill back up with the runny egg. Repeat once or twice more until the egg has just set." },
                    { 3, 3, "Wash and roughly chop the vegetables – there’s no need to peel them. Break the garlic bulb into cloves, leaving them unpeeled." },
                    { 4, 3, "Place the fish and asparagus onto the lined sheet pan then season with salt and pepper." },
                    { 1, 4, "Add 1 tsp salt to the boiling water, add 350g spaghetti and when the water comes back to the boil, cook at a constant simmer, covered, for 10 minutes or until al dente (just cooked)." },
                    { 2, 4, "At this point you can fill the omelette with whatever you like – some grated cheese, sliced ham, fresh herbs, sautéed mushrooms or smoked salmon all work well. Scatter the filling over the top of the omelette and fold gently in half with the spatula. Slide onto a plate to serve" },
                    { 3, 4, "Pile all the veg, garlic and herbs into the middle of a large roasting tray and drizzle with oil." },
                    { 4, 4, "Pour the lemon butter sauce over the fish and asparagus and top the fish with lemon slices (optional)." },
                    { 1, 5, "Squash 2 peeled plump garlic cloves with the blade of a knife, just to bruise it." },
                    { 3, 5, "Drizzle the beef with oil and season well with sea salt and black pepper, then rub all over the meat. Place the beef on top of the vegetables." },
                    { 4, 5, "Place in the oven and bake for 10-12 minutes or until the fish and asparagus are cooked. Fish is cooked when it flakes easily and the flesh is opaque, white throughout." },
                    { 1, 6, "While the spaghetti is cooking, fry the pancetta with the garlic. Drop 50g unsalted butter into a large frying pan or wok and, as soon as the butter has melted, tip in the pancetta and garlic." },
                    { 3, 6, "Place the tray in the oven, then turn the heat down immediately to 200°C/400°F/gas 6 and cook for 1 hour for medium beef. If you prefer it medium-rare, take it out 5 to 10 minutes earlier. For well done, leave it in for another 10 to 15 minutes." },
                    { 4, 6, "Place in the oven and bake for 10-12 minutes or until the fish and asparagus are cooked. Fish is cooked when it flakes easily and the flesh is opaque, white throughout." },
                    { 1, 7, "Leave to cook on a medium heat for about 5 minutes, stirring often, until the pancetta is golden and crisp. The garlic has now imparted its flavour, so take it out with a slotted spoon and discard." },
                    { 3, 7, "If you’re doing roast potatoes and veggies, this is the time to crack on with them – get them into the oven for the last 45 minutes of cooking." },
                    { 4, 7, "Remove from the oven and serve." },
                    { 1, 8, "Keep the heat under the pancetta on low. When the pasta is ready, lift it from the water with a pasta fork or tongs and put it in the frying pan with the pancetta. Don’t worry if a little water drops in the pan as well (you want this to happen) and don’t throw the pasta water away yet." },
                    { 3, 8, "Baste the beef halfway through cooking and if the veg look dry, add a splash of water to the tray to stop them from burning." },
                    { 1, 9, "Mix most of the cheese in with the eggs, keeping a small handful back for sprinkling over later." },
                    { 3, 9, "When the beef is cooked to your liking, take the tray out of the oven and transfer the beef to a board to rest for 15 minutes or so. Cover it with a layer of tin foil and a tea towel and leave aside while you make your gravy, horseradish sauce and Yorkshire puddings." },
                    { 1, 10, "Take the pan of spaghetti and pancetta off the heat. Now quickly pour in the eggs and cheese. Using the tongs or a long fork, lift up the spaghetti so it mixes easily with the egg mixture, which thickens but doesn’t scramble, and everything is coated." },
                    { 1, 11, "Add extra pasta cooking water to keep it saucy (several tablespoons should do it). You don’t want it wet, just moist. Season with a little salt, if needed." },
                    { 1, 12, "Use a long-pronged fork to twist the pasta on to the serving plate or bowl. Serve immediately with a little sprinkling of the remaining cheese and a grating of black pepper. If the dish does get a little dry before serving, splash in some more hot pasta water and the glossy sauciness will be revived." }
                });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "There are lots of baked fish recipes out there, but this oven-fried version is hands-down our favorite. With just 10 minutes of prep time, this recipe is fast and easy enough to satisfy your Friday fish fry cravings any night of the week. It would also taste great served on a bun with tartar sauce and a slice of cheese (so go ahead and ditch the drive-thru).");

            migrationBuilder.CreateIndex(
                name: "IX_DescriptionSteps_RecipeId",
                table: "DescriptionSteps",
                column: "RecipeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DescriptionSteps");

            migrationBuilder.AddColumn<string>(
                name: "step1",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "step10",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "step11",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "step12",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "step13",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "step14",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "step15",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "step2",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "step3",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "step4",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "step5",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "step6",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "step7",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "step8",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "step9",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "step1", "step10", "step11", "step12", "step2", "step3", "step4", "step5", "step6", "step7", "step8", "step9" },
                values: new object[] { "Put a large saucepan of water on to boil. ", "Take the pan of spaghetti and pancetta off the heat. Now quickly pour in the eggs and cheese. Using the tongs or a long fork, lift up the spaghetti so it mixes easily with the egg mixture, which thickens but doesn’t scramble, and everything is coated. ", "Add extra pasta cooking water to keep it saucy (several tablespoons should do it). You don’t want it wet, just moist. Season with a little salt, if needed.", "Use a long-pronged fork to twist the pasta on to the serving plate or bowl. Serve immediately with a little sprinkling of the remaining cheese and a grating of black pepper. If the dish does get a little dry before serving, splash in some more hot pasta water and the glossy sauciness will be revived.", "Finely chop the 100g pancetta, having first removed any rind. Finely grate 50g pecorino cheese and 50g parmesan and mix them together. ", "Beat the 3 large eggs in a medium bowl and season with a little freshly grated black pepper. Set everything aside. ", "Add 1 tsp salt to the boiling water, add 350g spaghetti and when the water comes back to the boil, cook at a constant simmer, covered, for 10 minutes or until al dente (just cooked). ", "Squash 2 peeled plump garlic cloves with the blade of a knife, just to bruise it. ", "While the spaghetti is cooking, fry the pancetta with the garlic. Drop 50g unsalted butter into a large frying pan or wok and, as soon as the butter has melted, tip in the pancetta and garlic. ", "Leave to cook on a medium heat for about 5 minutes, stirring often, until the pancetta is golden and crisp. The garlic has now imparted its flavour, so take it out with a slotted spoon and discard. ", "Keep the heat under the pancetta on low. When the pasta is ready, lift it from the water with a pasta fork or tongs and put it in the frying pan with the pancetta. Don’t worry if a little water drops in the pan as well (you want this to happen) and don’t throw the pasta water away yet. ", "Mix most of the cheese in with the eggs, keeping a small handful back for sprinkling over later. " });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "step1", "step2", "step3", "step4" },
                values: new object[] { "Season the beaten eggs well with salt and pepper. Heat the oil and butter in a non-stick frying pan over a medium-low heat until the butter has melted and is foaming. ", "Pour the eggs into the pan, tilt the pan ever so slightly from one side to another to allow the eggs to swirl and cover the surface of the pan completely. Let the mixture cook for about 20 seconds then scrape a line through the middle with a spatula. ", "Tilt the pan again to allow it to fill back up with the runny egg. Repeat once or twice more until the egg has just set.  ", "At this point you can fill the omelette with whatever you like – some grated cheese, sliced ham, fresh herbs, sautéed mushrooms or smoked salmon all work well. Scatter the filling over the top of the omelette and fold gently in half with the spatula. Slide onto a plate to serve " });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "step1", "step2", "step3", "step4", "step5", "step6", "step7", "step8", "step9" },
                values: new object[] { "Remove the beef from the fridge 30 minutes before you want to cook it, to let it come up to room temperature. ", "Preheat the oven to 240°C/475°F/ gas 9. ", "Wash and roughly chop the vegetables – there’s no need to peel them. Break the garlic bulb into cloves, leaving them unpeeled. ", "Pile all the veg, garlic and herbs into the middle of a large roasting tray and drizzle with oil. ", " Drizzle the beef with oil and season well with sea salt and black pepper, then rub all over the meat. Place the beef on top of the vegetables.", "Place the tray in the oven, then turn the heat down immediately to 200°C/400°F/gas 6 and cook for 1 hour for medium beef. If you prefer it medium-rare, take it out 5 to 10 minutes earlier. For well done, leave it in for another 10 to 15 minutes. ", "If you’re doing roast potatoes and veggies, this is the time to crack on with them – get them into the oven for the last 45 minutes of cooking. ", "Baste the beef halfway through cooking and if the veg look dry, add a splash of water to the tray to stop them from burning. ", "When the beef is cooked to your liking, take the tray out of the oven and transfer the beef to a board to rest for 15 minutes or so. Cover it with a layer of tin foil and a tea towel and leave aside while you make your gravy, horseradish sauce and Yorkshire puddings. " });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "step1", "step2", "step3", "step4", "step5", "step6", "step7" },
                values: new object[] { "There are lots of baked fish recipes out there, but this oven-fried version is hands-down our favorite. With just 10 minutes of prep time, this recipe is fast and easy enough to satisfy your Friday fish fry cravings any night of the week. It would also taste great served on a bun with tartar sauce and a slice of cheese (so go ahead and ditch the drive-thru). ", "Pre-heat the oven to 200ºC/400ºF and line a sheet pan with parchment/baking paper.  ", "Combine the butter, lemon, garlic and herbs in a saucepan and bring to a simmer. Cook for 2-3 minutes until fragrant then remove from the heat and set aside to cool slightly.  ", "Place the fish and asparagus onto the lined sheet pan then season with salt and pepper.   ", " Pour the lemon butter sauce over the fish and asparagus and top the fish with lemon slices (optional). ", "Place in the oven and bake for 10-12 minutes or until the fish and asparagus are cooked. Fish is cooked when it flakes easily and the flesh is opaque, white throughout.  ", "Place in the oven and bake for 10-12 minutes or until the fish and asparagus are cooked. Fish is cooked when it flakes easily and the flesh is opaque, white throughout.  ", "Remove from the oven and serve.  " });
        }
    }
}

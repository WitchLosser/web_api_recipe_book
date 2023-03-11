using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrustructure
{
    public static class DbContextExtensions
    {
        public static void SeedIngredients(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ingredient>().HasData(new[]
            {
                new Ingredient() { Id = 1, Name = "Egg" },
                new Ingredient() { Id = 2, Name = "beef" },
                new Ingredient() { Id = 3, Name = "Fish" },
                new Ingredient() { Id = 4, Name = "Tomato" },
                new Ingredient() { Id = 5, Name = "Cheese" },
                new Ingredient() { Id = 6, Name = "Oil" },
                new Ingredient() { Id = 7, Name = "Sugar" },
                new Ingredient() { Id = 8, Name = "Ketchup" },
                new Ingredient() { Id = 9, Name = "Spageti" },
                new Ingredient() { Id = 10, Name = "Dought" },
                new Ingredient() { Id = 11, Name = "Sour cream" }
            });
        }


        public static void SeedRecipes(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RecipeIngredient>().HasData(new[]
            {
                new RecipeIngredient() { RecipeId = 1, IngredientId = 1 },
                new RecipeIngredient() { RecipeId = 1, IngredientId = 2 },
                new RecipeIngredient() { RecipeId = 1, IngredientId = 5 },
                new RecipeIngredient() { RecipeId = 1, IngredientId = 9 },

                new RecipeIngredient() { RecipeId = 2, IngredientId = 1 },
                new RecipeIngredient() { RecipeId = 2, IngredientId = 6 },
                new RecipeIngredient() { RecipeId = 2, IngredientId = 8 },

                new RecipeIngredient() { RecipeId = 3, IngredientId = 2 },
                new RecipeIngredient() { RecipeId = 3, IngredientId = 6 },
                new RecipeIngredient() { RecipeId = 3, IngredientId = 8 },
                new RecipeIngredient() { RecipeId = 3, IngredientId = 11 },

                new RecipeIngredient() { RecipeId = 4, IngredientId = 3 },
                new RecipeIngredient() { RecipeId = 4, IngredientId = 4 },
                new RecipeIngredient() { RecipeId = 4, IngredientId = 6 }
            });

            modelBuilder.Entity<Recipe>().HasData(new[]
            {
                new Recipe() { Id = 1, Name = "Carbonara",Description="This cheesy pasta dish is an Italian favourite and with the right technique, you can make it perfect every time ", MinToCook = 40,
                    step1="Put a large saucepan of water on to boil. ",
                    step2="Finely chop the 100g pancetta, having first removed any rind. Finely grate 50g pecorino cheese and 50g parmesan and mix them together. ",
                    step3="Beat the 3 large eggs in a medium bowl and season with a little freshly grated black pepper. Set everything aside. ",
                    step4="Add 1 tsp salt to the boiling water, add 350g spaghetti and when the water comes back to the boil, cook at a constant simmer, covered, for 10 minutes or until al dente (just cooked). ",
                    step5="Squash 2 peeled plump garlic cloves with the blade of a knife, just to bruise it. ",
                    step6="While the spaghetti is cooking, fry the pancetta with the garlic. Drop 50g unsalted butter into a large frying pan or wok and, as soon as the butter has melted, tip in the pancetta and garlic. ",
                    step7="Leave to cook on a medium heat for about 5 minutes, stirring often, until the pancetta is golden and crisp. The garlic has now imparted its flavour, so take it out with a slotted spoon and discard. ",
                    step8="Keep the heat under the pancetta on low. When the pasta is ready, lift it from the water with a pasta fork or tongs and put it in the frying pan with the pancetta. Don’t worry if a little water drops in the pan as well (you want this to happen) and don’t throw the pasta water away yet. ",
                    step9="Mix most of the cheese in with the eggs, keeping a small handful back for sprinkling over later. ",
                    step10="Take the pan of spaghetti and pancetta off the heat. Now quickly pour in the eggs and cheese. Using the tongs or a long fork, lift up the spaghetti so it mixes easily with the egg mixture, which thickens but doesn’t scramble, and everything is coated. ",
                    step11="Add extra pasta cooking water to keep it saucy (several tablespoons should do it). You don’t want it wet, just moist. Season with a little salt, if needed.",
                    step12="Use a long-pronged fork to twist the pasta on to the serving plate or bowl. Serve immediately with a little sprinkling of the remaining cheese and a grating of black pepper. If the dish does get a little dry before serving, splash in some more hot pasta water and the glossy sauciness will be revived.",
                 
                },
                new Recipe() { Id = 2, Name = "omelette ",Description="Master the omelette with our simple recipe then add the filling of your choice – grated cheese, ham, fresh herbs, mushrooms and smoked salmon are favourites. ", MinToCook = 15,
                    step1="Season the beaten eggs well with salt and pepper. Heat the oil and butter in a non-stick frying pan over a medium-low heat until the butter has melted and is foaming. ",
                    step2="Pour the eggs into the pan, tilt the pan ever so slightly from one side to another to allow the eggs to swirl and cover the surface of the pan completely. Let the mixture cook for about 20 seconds then scrape a line through the middle with a spatula. ",
                    step3="Tilt the pan again to allow it to fill back up with the runny egg. Repeat once or twice more until the egg has just set.  ",
                    step4="At this point you can fill the omelette with whatever you like – some grated cheese, sliced ham, fresh herbs, sautéed mushrooms or smoked salmon all work well. Scatter the filling over the top of the omelette and fold gently in half with the spatula. Slide onto a plate to serve ",
                },
                new Recipe() { Id = 3, Name = "Roast beef",Description="A simple way to roast topside of beef to ensure it's super succulent, every time ", MinToCook =45,
                    step1="Remove the beef from the fridge 30 minutes before you want to cook it, to let it come up to room temperature. ",
                    step2="Preheat the oven to 240°C/475°F/ gas 9. ",
                    step3="Wash and roughly chop the vegetables – there’s no need to peel them. Break the garlic bulb into cloves, leaving them unpeeled. ",
                    step4="Pile all the veg, garlic and herbs into the middle of a large roasting tray and drizzle with oil. ",
                    step5=" Drizzle the beef with oil and season well with sea salt and black pepper, then rub all over the meat. Place the beef on top of the vegetables.",
                    step6="Place the tray in the oven, then turn the heat down immediately to 200°C/400°F/gas 6 and cook for 1 hour for medium beef. If you prefer it medium-rare, take it out 5 to 10 minutes earlier. For well done, leave it in for another 10 to 15 minutes. ",
                    step7="If you’re doing roast potatoes and veggies, this is the time to crack on with them – get them into the oven for the last 45 minutes of cooking. ",
                    step8="Baste the beef halfway through cooking and if the veg look dry, add a splash of water to the tray to stop them from burning. ",
                    step9="When the beef is cooked to your liking, take the tray out of the oven and transfer the beef to a board to rest for 15 minutes or so. Cover it with a layer of tin foil and a tea towel and leave aside while you make your gravy, horseradish sauce and Yorkshire puddings. ",
                },
                new Recipe() { Id = 4, Name = "Baked fish",Description="There are lots of baked fish recipes out there, but this oven-fried version is hands-down our favorite. With just 10 minutes of prep time, this recipe is fast and easy enough to satisfy your Friday fish fry cravings any night of the week. It would also taste great served on a bun with tartar sauce and a slice of cheese (so go ahead and ditch the drive-thru). ", MinToCook =60,
                    step1="Pre-heat the oven to 200ºC/400ºF and line a sheet pan with parchment/baking paper.  ",
                    step2="Combine the butter, lemon, garlic and herbs in a saucepan and bring to a simmer. Cook for 2-3 minutes until fragrant then remove from the heat and set aside to cool slightly.  ",
                    step3="Place the fish and asparagus onto the lined sheet pan then season with salt and pepper.   ",
                    step4=" Pour the lemon butter sauce over the fish and asparagus and top the fish with lemon slices (optional). ",
                    step5="Place in the oven and bake for 10-12 minutes or until the fish and asparagus are cooked. Fish is cooked when it flakes easily and the flesh is opaque, white throughout.  ",
                    step6="Place in the oven and bake for 10-12 minutes or until the fish and asparagus are cooked. Fish is cooked when it flakes easily and the flesh is opaque, white throughout.  ",
                    step7="Remove from the oven and serve.  ",
                }
            });
         

        }
    }
}
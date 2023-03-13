﻿// <auto-generated />
using Infrustructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Core.Migrations
{
    [DbContext(typeof(RecipeDbContext))]
    [Migration("20230313172431_descrUpdateDb")]
    partial class descrUpdateDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Core.Entities.DescriptionStep", b =>
                {
                    b.Property<int>("StepId")
                        .HasColumnType("int");

                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StepId", "RecipeId");

                    b.HasIndex("RecipeId");

                    b.ToTable("DescriptionSteps");

                    b.HasData(
                        new
                        {
                            StepId = 1,
                            RecipeId = 1,
                            Description = "Put a large saucepan of water on to boil."
                        },
                        new
                        {
                            StepId = 2,
                            RecipeId = 1,
                            Description = "Finely chop the 100g pancetta, having first removed any rind. Finely grate 50g pecorino cheese and 50g parmesan and mix them together."
                        },
                        new
                        {
                            StepId = 3,
                            RecipeId = 1,
                            Description = "Beat the 3 large eggs in a medium bowl and season with a little freshly grated black pepper. Set everything aside."
                        },
                        new
                        {
                            StepId = 4,
                            RecipeId = 1,
                            Description = "Add 1 tsp salt to the boiling water, add 350g spaghetti and when the water comes back to the boil, cook at a constant simmer, covered, for 10 minutes or until al dente (just cooked)."
                        },
                        new
                        {
                            StepId = 5,
                            RecipeId = 1,
                            Description = "Squash 2 peeled plump garlic cloves with the blade of a knife, just to bruise it."
                        },
                        new
                        {
                            StepId = 6,
                            RecipeId = 1,
                            Description = "While the spaghetti is cooking, fry the pancetta with the garlic. Drop 50g unsalted butter into a large frying pan or wok and, as soon as the butter has melted, tip in the pancetta and garlic."
                        },
                        new
                        {
                            StepId = 7,
                            RecipeId = 1,
                            Description = "Leave to cook on a medium heat for about 5 minutes, stirring often, until the pancetta is golden and crisp. The garlic has now imparted its flavour, so take it out with a slotted spoon and discard."
                        },
                        new
                        {
                            StepId = 8,
                            RecipeId = 1,
                            Description = "Keep the heat under the pancetta on low. When the pasta is ready, lift it from the water with a pasta fork or tongs and put it in the frying pan with the pancetta. Don’t worry if a little water drops in the pan as well (you want this to happen) and don’t throw the pasta water away yet."
                        },
                        new
                        {
                            StepId = 9,
                            RecipeId = 1,
                            Description = "Mix most of the cheese in with the eggs, keeping a small handful back for sprinkling over later."
                        },
                        new
                        {
                            StepId = 10,
                            RecipeId = 1,
                            Description = "Take the pan of spaghetti and pancetta off the heat. Now quickly pour in the eggs and cheese. Using the tongs or a long fork, lift up the spaghetti so it mixes easily with the egg mixture, which thickens but doesn’t scramble, and everything is coated."
                        },
                        new
                        {
                            StepId = 11,
                            RecipeId = 1,
                            Description = "Add extra pasta cooking water to keep it saucy (several tablespoons should do it). You don’t want it wet, just moist. Season with a little salt, if needed."
                        },
                        new
                        {
                            StepId = 12,
                            RecipeId = 1,
                            Description = "Use a long-pronged fork to twist the pasta on to the serving plate or bowl. Serve immediately with a little sprinkling of the remaining cheese and a grating of black pepper. If the dish does get a little dry before serving, splash in some more hot pasta water and the glossy sauciness will be revived."
                        },
                        new
                        {
                            StepId = 1,
                            RecipeId = 2,
                            Description = "Season the beaten eggs well with salt and pepper. Heat the oil and butter in a non-stick frying pan over a medium-low heat until the butter has melted and is foaming."
                        },
                        new
                        {
                            StepId = 2,
                            RecipeId = 2,
                            Description = "Pour the eggs into the pan, tilt the pan ever so slightly from one side to another to allow the eggs to swirl and cover the surface of the pan completely. Let the mixture cook for about 20 seconds then scrape a line through the middle with a spatula."
                        },
                        new
                        {
                            StepId = 3,
                            RecipeId = 2,
                            Description = "Tilt the pan again to allow it to fill back up with the runny egg. Repeat once or twice more until the egg has just set."
                        },
                        new
                        {
                            StepId = 4,
                            RecipeId = 2,
                            Description = "At this point you can fill the omelette with whatever you like – some grated cheese, sliced ham, fresh herbs, sautéed mushrooms or smoked salmon all work well. Scatter the filling over the top of the omelette and fold gently in half with the spatula. Slide onto a plate to serve"
                        },
                        new
                        {
                            StepId = 1,
                            RecipeId = 3,
                            Description = "Remove the beef from the fridge 30 minutes before you want to cook it, to let it come up to room temperature."
                        },
                        new
                        {
                            StepId = 2,
                            RecipeId = 3,
                            Description = "Preheat the oven to 240°C/475°F/ gas 9."
                        },
                        new
                        {
                            StepId = 3,
                            RecipeId = 3,
                            Description = "Wash and roughly chop the vegetables – there’s no need to peel them. Break the garlic bulb into cloves, leaving them unpeeled."
                        },
                        new
                        {
                            StepId = 4,
                            RecipeId = 3,
                            Description = "Pile all the veg, garlic and herbs into the middle of a large roasting tray and drizzle with oil."
                        },
                        new
                        {
                            StepId = 5,
                            RecipeId = 3,
                            Description = "Drizzle the beef with oil and season well with sea salt and black pepper, then rub all over the meat. Place the beef on top of the vegetables."
                        },
                        new
                        {
                            StepId = 6,
                            RecipeId = 3,
                            Description = "Place the tray in the oven, then turn the heat down immediately to 200°C/400°F/gas 6 and cook for 1 hour for medium beef. If you prefer it medium-rare, take it out 5 to 10 minutes earlier. For well done, leave it in for another 10 to 15 minutes."
                        },
                        new
                        {
                            StepId = 7,
                            RecipeId = 3,
                            Description = "If you’re doing roast potatoes and veggies, this is the time to crack on with them – get them into the oven for the last 45 minutes of cooking."
                        },
                        new
                        {
                            StepId = 8,
                            RecipeId = 3,
                            Description = "Baste the beef halfway through cooking and if the veg look dry, add a splash of water to the tray to stop them from burning."
                        },
                        new
                        {
                            StepId = 9,
                            RecipeId = 3,
                            Description = "When the beef is cooked to your liking, take the tray out of the oven and transfer the beef to a board to rest for 15 minutes or so. Cover it with a layer of tin foil and a tea towel and leave aside while you make your gravy, horseradish sauce and Yorkshire puddings."
                        },
                        new
                        {
                            StepId = 1,
                            RecipeId = 4,
                            Description = "Pre-heat the oven to 200ºC/400ºF and line a sheet pan with parchment/baking paper."
                        },
                        new
                        {
                            StepId = 2,
                            RecipeId = 4,
                            Description = "Combine the butter, lemon, garlic and herbs in a saucepan and bring to a simmer. Cook for 2-3 minutes until fragrant then remove from the heat and set aside to cool slightly."
                        },
                        new
                        {
                            StepId = 3,
                            RecipeId = 4,
                            Description = "Place the fish and asparagus onto the lined sheet pan then season with salt and pepper."
                        },
                        new
                        {
                            StepId = 4,
                            RecipeId = 4,
                            Description = "Pour the lemon butter sauce over the fish and asparagus and top the fish with lemon slices (optional)."
                        },
                        new
                        {
                            StepId = 5,
                            RecipeId = 4,
                            Description = "Place in the oven and bake for 10-12 minutes or until the fish and asparagus are cooked. Fish is cooked when it flakes easily and the flesh is opaque, white throughout."
                        },
                        new
                        {
                            StepId = 6,
                            RecipeId = 4,
                            Description = "Place in the oven and bake for 10-12 minutes or until the fish and asparagus are cooked. Fish is cooked when it flakes easily and the flesh is opaque, white throughout."
                        },
                        new
                        {
                            StepId = 7,
                            RecipeId = 4,
                            Description = "Remove from the oven and serve."
                        });
                });

            modelBuilder.Entity("Core.Entities.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("Id");

                    b.ToTable("Ingredient");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Egg"
                        },
                        new
                        {
                            Id = 2,
                            Name = "beef"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Fish"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Tomato"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Cheese"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Oil"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Sugar"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Ketchup"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Spageti"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Dought"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Sour cream"
                        });
                });

            modelBuilder.Entity("Core.Entities.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MinToCook")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Recipes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "This cheesy pasta dish is an Italian favourite and with the right technique, you can make it perfect every time ",
                            MinToCook = 40,
                            Name = "Carbonara"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Master the omelette with our simple recipe then add the filling of your choice – grated cheese, ham, fresh herbs, mushrooms and smoked salmon are favourites. ",
                            MinToCook = 15,
                            Name = "omelette "
                        },
                        new
                        {
                            Id = 3,
                            Description = "A simple way to roast topside of beef to ensure it's super succulent, every time ",
                            MinToCook = 45,
                            Name = "Roast beef"
                        },
                        new
                        {
                            Id = 4,
                            Description = "There are lots of baked fish recipes out there, but this oven-fried version is hands-down our favorite. With just 10 minutes of prep time, this recipe is fast and easy enough to satisfy your Friday fish fry cravings any night of the week. It would also taste great served on a bun with tartar sauce and a slice of cheese (so go ahead and ditch the drive-thru).",
                            MinToCook = 60,
                            Name = "Baked fish"
                        });
                });

            modelBuilder.Entity("Core.Entities.RecipeIngredient", b =>
                {
                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.HasKey("IngredientId", "RecipeId");

                    b.HasIndex("RecipeId");

                    b.ToTable("RecipeIngredient");

                    b.HasData(
                        new
                        {
                            IngredientId = 1,
                            RecipeId = 1
                        },
                        new
                        {
                            IngredientId = 2,
                            RecipeId = 1
                        },
                        new
                        {
                            IngredientId = 5,
                            RecipeId = 1
                        },
                        new
                        {
                            IngredientId = 9,
                            RecipeId = 1
                        },
                        new
                        {
                            IngredientId = 1,
                            RecipeId = 2
                        },
                        new
                        {
                            IngredientId = 6,
                            RecipeId = 2
                        },
                        new
                        {
                            IngredientId = 8,
                            RecipeId = 2
                        },
                        new
                        {
                            IngredientId = 2,
                            RecipeId = 3
                        },
                        new
                        {
                            IngredientId = 6,
                            RecipeId = 3
                        },
                        new
                        {
                            IngredientId = 8,
                            RecipeId = 3
                        },
                        new
                        {
                            IngredientId = 11,
                            RecipeId = 3
                        },
                        new
                        {
                            IngredientId = 3,
                            RecipeId = 4
                        },
                        new
                        {
                            IngredientId = 4,
                            RecipeId = 4
                        },
                        new
                        {
                            IngredientId = 6,
                            RecipeId = 4
                        });
                });

            modelBuilder.Entity("Core.Entities.DescriptionStep", b =>
                {
                    b.HasOne("Core.Entities.Recipe", "Recipe")
                        .WithMany("DescriptionSteps")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("Core.Entities.RecipeIngredient", b =>
                {
                    b.HasOne("Core.Entities.Ingredient", "Ingredient")
                        .WithMany("Recipes")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Recipe", "Recipe")
                        .WithMany("Ingredients")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("Core.Entities.Ingredient", b =>
                {
                    b.Navigation("Recipes");
                });

            modelBuilder.Entity("Core.Entities.Recipe", b =>
                {
                    b.Navigation("DescriptionSteps");

                    b.Navigation("Ingredients");
                });
#pragma warning restore 612, 618
        }
    }
}

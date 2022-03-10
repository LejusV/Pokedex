using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Rowlet Species to store common natural stats of all Rowlets
	#region SpeciesRowlet
	public class SpeciesRowlet : PokemonSpecies
	{
#nullable enable
		private static SpeciesRowlet? _instance = null;
#nullable restore
        public static SpeciesRowlet Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesRowlet();
                }
                return _instance;
            }
        }

		#region SpeciesRowlet Constructor
		public SpeciesRowlet() : base(
			"Rowlet",
			0.3,
			1.5,
			68, // HPs
			55, 55, // Attack & Defense
			50, 50, // Special Attack & Defense
			42		
		)
		{
			InitMovesList();
		}
		#endregion

		#region Methods
		private void InitMovesList()
		{
			_moveList = new List<string>()
			{
				"Swords-Dance",
				"Fury-Attack",
				"Tackle",
				"Growl",
				"Peck",
				"Razor-Leaf",
				"Solar-Beam",
				"Toxic",
				"Double-Team",
				"Confuse-Ray",
				"Light-Screen",
				"Haze",
				"Rest",
				"Substitute",
				"Curse",
				"Protect",
				"Foresight",
				"False-Swipe",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Baton-Pass",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Facade",
				"Nature-Power",
				"Feather-Dance",
				"Astonish",
				"Leaf-Blade",
				"Roost",
				"Pluck",
				"Sucker-Punch",
				"Energy-Ball",
				"Brave-Bird",
				"Nasty-Plot",
				"Shadow-Claw",
				"Defog",
				"Grass-Knot",
				"Ominous-Wind",
				"Round",
				"Echoed-Voice",
				"Grass-Pledge",
				"Work-Up",
				"Confide",
				"Leafage"
			};
		}
		#endregion
	}
	#endregion

	//Rowlet PokemonInstance Class
	#region Rowlet
	public class RowletInstance : PokemonInstance
	{
		#region Rowlet Constructors
		/// <summary>
		/// Rowlet Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public RowletInstance(string nickname, int level)
		: base(
				722,
				SpeciesRowlet.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rowlet Builder only waiting for a Level
		/// </summary>
		public RowletInstance(int level)
		: base(
				722,
				SpeciesRowlet.Instance, // PokemonInstance Species
				"Rowlet", level,
				Grass.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rowlet Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Rowlet() : base(
			722,
			SpeciesRowlet.Instance, // PokemonInstance Species
			Grass.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
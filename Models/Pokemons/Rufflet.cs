using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Rufflet Species to store common natural stats of all Rufflets
	#region SpeciesRufflet
	public class SpeciesRufflet : PokemonSpecies
	{
#nullable enable
		private static SpeciesRufflet? _instance = null;
#nullable restore
        public static SpeciesRufflet Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesRufflet();
                }
                return _instance;
            }
        }

		#region SpeciesRufflet Constructor
		public SpeciesRufflet() : base(
			"Rufflet",
			0.5,
			10.5,
			70, // HPs
			83, 50, // Attack & Defense
			37, 50, // Special Attack & Defense
			60		
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
				"Cut",
				"Wing-Attack",
				"Whirlwind",
				"Fly",
				"Fury-Attack",
				"Thrash",
				"Leer",
				"Peck",
				"Strength",
				"Toxic",
				"Double-Team",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Protect",
				"Scary-Face",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Heat-Wave",
				"Facade",
				"Superpower",
				"Secret-Power",
				"Crush-Claw",
				"Rock-Tomb",
				"Aerial-Ace",
				"Bulk-Up",
				"Roost",
				"Pluck",
				"Tailwind",
				"U-Turn",
				"Air-Slash",
				"Brave-Bird",
				"Shadow-Claw",
				"Defog",
				"Hone-Claws",
				"Round",
				"Sky-Drop",
				"Retaliate",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Rufflet PokemonInstance Class
	#region Rufflet
	public class RuffletInstance : PokemonInstance
	{
		#region Rufflet Constructors
		/// <summary>
		/// Rufflet Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public RuffletInstance(string nickname, int level)
		: base(
				627,
				SpeciesRufflet.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rufflet Builder only waiting for a Level
		/// </summary>
		public RuffletInstance(int level)
		: base(
				627,
				SpeciesRufflet.Instance, // PokemonInstance Species
				"Rufflet", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rufflet Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Rufflet() : base(
			627,
			SpeciesRufflet.Instance, // PokemonInstance Species
			Normal.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
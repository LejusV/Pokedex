using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Litten Species to store common natural stats of all Littens
	#region SpeciesLitten
	public class SpeciesLitten : PokemonSpecies
	{
#nullable enable
		private static SpeciesLitten? _instance = null;
#nullable restore
        public static SpeciesLitten Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesLitten();
                }
                return _instance;
            }
        }

		#region SpeciesLitten Constructor
		public SpeciesLitten() : base(
			725,
			"Litten",
			0.4,
			4.3,
			45, // HPs
			65, 40, // Attack & Defense
			60, 40, // Special Attack & Defense
			70		
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
				"Scratch",
				"Swords-Dance",
				"Double-Kick",
				"Body-Slam",
				"Thrash",
				"Leer",
				"Bite",
				"Growl",
				"Roar",
				"Ember",
				"Flamethrower",
				"Toxic",
				"Double-Team",
				"Lick",
				"Fire-Blast",
				"Leech-Life",
				"Fury-Swipes",
				"Rest",
				"Substitute",
				"Protect",
				"Scary-Face",
				"Outrage",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Sunny-Day",
				"Crunch",
				"Fake-Out",
				"Heat-Wave",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Taunt",
				"Revenge",
				"Overheat",
				"Bulk-Up",
				"U-Turn",
				"Flare-Blitz",
				"Nasty-Plot",
				"Shadow-Claw",
				"Fire-Fang",
				"Flame-Charge",
				"Round",
				"Acrobatics",
				"Fire-Pledge",
				"Work-Up",
				"Confide",
				"Power-Trip"
			};
		}
		#endregion
	}
	#endregion

	//Litten PokemonInstance Class
	#region Litten
	public class LittenInstance : PokemonInstance
	{
		#region Litten Constructors
		/// <summary>
		/// Litten Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public LittenInstance(string nickname, int level)
		: base(
				SpeciesLitten.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Litten Builder only waiting for a Level
		/// </summary>
		public LittenInstance(int level)
		: base(
				SpeciesLitten.Instance, // PokemonInstance Species
				"Litten", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Litten Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public LittenInstance() : base(
			SpeciesLitten.Instance, // PokemonInstance Species
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
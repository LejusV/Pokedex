using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Decidueye Species to store common natural stats of all Decidueyes
	#region SpeciesDecidueye
	public class SpeciesDecidueye : PokemonSpecies
	{
#nullable enable
		private static SpeciesDecidueye? _instance = null;
#nullable restore
        public static SpeciesDecidueye Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDecidueye();
                }
                return _instance;
            }
        }

		#region SpeciesDecidueye Constructor
		public SpeciesDecidueye() : base(
			"Decidueye",
			1.6,
			36.6,
			78, // HPs
			107, 75, // Attack & Defense
			100, 100, // Special Attack & Defense
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
				"Swords-Dance",
				"Fury-Attack",
				"Tackle",
				"Growl",
				"Peck",
				"Razor-Leaf",
				"Solar-Beam",
				"Toxic",
				"Double-Team",
				"Light-Screen",
				"Rest",
				"Substitute",
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
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Shadow-Ball",
				"Facade",
				"Nature-Power",
				"Feather-Dance",
				"Astonish",
				"Frenzy-Plant",
				"Leaf-Blade",
				"Roost",
				"Pluck",
				"U-Turn",
				"Sucker-Punch",
				"Energy-Ball",
				"Brave-Bird",
				"Giga-Impact",
				"Nasty-Plot",
				"Shadow-Claw",
				"Shadow-Sneak",
				"Leaf-Storm",
				"Grass-Knot",
				"Ominous-Wind",
				"Smack-Down",
				"Low-Sweep",
				"Round",
				"Echoed-Voice",
				"Acrobatics",
				"Grass-Pledge",
				"Work-Up",
				"Phantom-Force",
				"Confide",
				"Spirit-Shackle",
				"Leafage"
			};
		}
		#endregion
	}
	#endregion

	//Decidueye PokemonInstance Class
	#region Decidueye
	public class DecidueyeInstance : PokemonInstance
	{
		#region Decidueye Constructors
		/// <summary>
		/// Decidueye Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DecidueyeInstance(string nickname, int level)
		: base(
				724,
				SpeciesDecidueye.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Decidueye Builder only waiting for a Level
		/// </summary>
		public DecidueyeInstance(int level)
		: base(
				724,
				SpeciesDecidueye.Instance, // PokemonInstance Species
				"Decidueye", level,
				Grass.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Decidueye Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Decidueye() : base(
			724,
			SpeciesDecidueye.Instance, // PokemonInstance Species
			Grass.Instance, Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
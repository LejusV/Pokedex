using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Staraptor Species to store common natural stats of all Staraptors
	#region SpeciesStaraptor
	public class SpeciesStaraptor : PokemonSpecies
	{
#nullable enable
		private static SpeciesStaraptor? _instance = null;
#nullable restore
        public static SpeciesStaraptor Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesStaraptor();
                }
                return _instance;
            }
        }

		#region SpeciesStaraptor Constructor
		public SpeciesStaraptor() : base(
			398,
			"Staraptor",
			1.2,
			24.9,
			85, // HPs
			120, 70, // Attack & Defense
			50, 60, // Special Attack & Defense
			100		
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
				"Wing-Attack",
				"Whirlwind",
				"Fly",
				"Tackle",
				"Take-Down",
				"Growl",
				"Hyper-Beam",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Double-Team",
				"Swift",
				"Sky-Attack",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Endure",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Uproar",
				"Heat-Wave",
				"Facade",
				"Endeavor",
				"Secret-Power",
				"Air-Cutter",
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"Pluck",
				"Tailwind",
				"U-Turn",
				"Close-Combat",
				"Brave-Bird",
				"Giga-Impact",
				"Defog",
				"Captivate",
				"Ominous-Wind",
				"Round",
				"Echoed-Voice",
				"Retaliate",
				"Final-Gambit",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Staraptor PokemonInstance Class
	#region Staraptor
	public class StaraptorInstance : PokemonInstance
	{
		#region Staraptor Constructors
		/// <summary>
		/// Staraptor Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public StaraptorInstance(string nickname, int level)
		: base(
				SpeciesStaraptor.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Staraptor Builder only waiting for a Level
		/// </summary>
		public StaraptorInstance(int level)
		: base(
				SpeciesStaraptor.Instance, // PokemonInstance Species
				"Staraptor", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Staraptor Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public StaraptorInstance() : base(
			SpeciesStaraptor.Instance, // PokemonInstance Species
			Normal.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
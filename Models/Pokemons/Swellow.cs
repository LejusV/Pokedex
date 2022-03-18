using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Swellow Species to store common natural stats of all Swellows
	#region SpeciesSwellow
	public class SpeciesSwellow : PokemonSpecies
	{
#nullable enable
		private static SpeciesSwellow? _instance = null;
#nullable restore
        public static SpeciesSwellow Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSwellow();
                }
                return _instance;
            }
        }

		#region SpeciesSwellow Constructor
		public SpeciesSwellow() : base(
			277,
			"Swellow",
			0.7,
			19.8,
			60, // HPs
			85, 60, // Attack & Defense
			75, 50, // Special Attack & Defense
			125		
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
				"Fly",
				"Double-Edge",
				"Growl",
				"Hyper-Beam",
				"Peck",
				"Counter",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Mimic",
				"Double-Team",
				"Focus-Energy",
				"Swift",
				"Sky-Attack",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Reversal",
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
				"Air-Slash",
				"Brave-Bird",
				"Giga-Impact",
				"Defog",
				"Captivate",
				"Ominous-Wind",
				"Round",
				"Echoed-Voice",
				"Quick-Guard",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Swellow PokemonInstance Class
	#region Swellow
	public class SwellowInstance : PokemonInstance
	{
		#region Swellow Constructors
		/// <summary>
		/// Swellow Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SwellowInstance(string nickname, int level)
		: base(
				SpeciesSwellow.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swellow Builder only waiting for a Level
		/// </summary>
		public SwellowInstance(int level)
		: base(
				SpeciesSwellow.Instance, // PokemonInstance Species
				"Swellow", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swellow Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SwellowInstance() : base(
			SpeciesSwellow.Instance, // PokemonInstance Species
			Normal.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
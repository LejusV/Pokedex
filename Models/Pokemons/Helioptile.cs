using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Helioptile Species to store common natural stats of all Helioptiles
	#region SpeciesHelioptile
	public class SpeciesHelioptile : PokemonSpecies
	{
#nullable enable
		private static SpeciesHelioptile? _instance = null;
#nullable restore
        public static SpeciesHelioptile Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesHelioptile();
                }
                return _instance;
            }
        }

		#region SpeciesHelioptile Constructor
		public SpeciesHelioptile() : base(
			694,
			"Helioptile",
			0.5,
			6.0,
			44, // HPs
			38, 33, // Attack & Defense
			61, 43, // Special Attack & Defense
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
				"Pound",
				"Razor-Wind",
				"Cut",
				"Tail-Whip",
				"Surf",
				"Thunder-Shock",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Dig",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Double-Team",
				"Light-Screen",
				"Glare",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Sandstorm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Facade",
				"Charge",
				"Secret-Power",
				"Camouflage",
				"Rock-Tomb",
				"Signal-Beam",
				"Shock-Wave",
				"U-Turn",
				"Magnet-Rise",
				"Dark-Pulse",
				"Grass-Knot",
				"Charge-Beam",
				"Low-Sweep",
				"Round",
				"Volt-Switch",
				"Bulldoze",
				"Dragon-Tail",
				"Electroweb",
				"Wild-Charge",
				"Parabolic-Charge",
				"Electrify",
				"Confide",
				"Electric-Terrain"
			};
		}
		#endregion
	}
	#endregion

	//Helioptile PokemonInstance Class
	#region Helioptile
	public class HelioptileInstance : PokemonInstance
	{
		#region Helioptile Constructors
		/// <summary>
		/// Helioptile Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public HelioptileInstance(string nickname, int level)
		: base(
				SpeciesHelioptile.Instance, // Pokemon Species
				nickname, level,
				Electric.Instance, Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Helioptile Builder only waiting for a Level
		/// </summary>
		public HelioptileInstance(int level)
		: base(
				SpeciesHelioptile.Instance, // PokemonInstance Species
				"Helioptile", level,
				Electric.Instance, Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Helioptile Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public HelioptileInstance() : base(
			SpeciesHelioptile.Instance, // PokemonInstance Species
			Electric.Instance, Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
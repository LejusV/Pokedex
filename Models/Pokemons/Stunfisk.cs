using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Stunfisk Species to store common natural stats of all Stunfisks
	#region SpeciesStunfisk
	public class SpeciesStunfisk : PokemonSpecies
	{
#nullable enable
		private static SpeciesStunfisk? _instance = null;
#nullable restore
        public static SpeciesStunfisk Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesStunfisk();
                }
                return _instance;
            }
        }

		#region SpeciesStunfisk Constructor
		public SpeciesStunfisk() : base(
			618,
			"Stunfisk",
			0.7,
			11.0,
			109, // HPs
			66, 84, // Attack & Defense
			81, 99, // Special Attack & Defense
			32		
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
				"Tackle",
				"Water-Gun",
				"Surf",
				"Thunder-Shock",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Double-Team",
				"Bide",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Flail",
				"Spite",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Spark",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Hidden-Power",
				"Rain-Dance",
				"Uproar",
				"Facade",
				"Revenge",
				"Yawn",
				"Endeavor",
				"Secret-Power",
				"Camouflage",
				"Mud-Sport",
				"Astonish",
				"Rock-Tomb",
				"Muddy-Water",
				"Bounce",
				"Mud-Shot",
				"Shock-Wave",
				"Water-Pulse",
				"Payback",
				"Me-First",
				"Magnet-Rise",
				"Aqua-Tail",
				"Earth-Power",
				"Mud-Bomb",
				"Discharge",
				"Stone-Edge",
				"Stealth-Rock",
				"Sludge-Wave",
				"Foul-Play",
				"Round",
				"Scald",
				"Reflect-Type",
				"Bulldoze",
				"Electroweb",
				"Confide",
				"Eerie-Impulse",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Stunfisk PokemonInstance Class
	#region Stunfisk
	public class StunfiskInstance : PokemonInstance
	{
		#region Stunfisk Constructors
		/// <summary>
		/// Stunfisk Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public StunfiskInstance(string nickname, int level)
		: base(
				SpeciesStunfisk.Instance, // Pokemon Species
				nickname, level,
				Ground.Instance, Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Stunfisk Builder only waiting for a Level
		/// </summary>
		public StunfiskInstance(int level)
		: base(
				SpeciesStunfisk.Instance, // PokemonInstance Species
				"Stunfisk", level,
				Ground.Instance, Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Stunfisk Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public StunfiskInstance() : base(
			SpeciesStunfisk.Instance, // PokemonInstance Species
			Ground.Instance, Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
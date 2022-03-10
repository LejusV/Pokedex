using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Mareep Species to store common natural stats of all Mareeps
	#region SpeciesMareep
	public class SpeciesMareep : PokemonSpecies
	{
#nullable enable
		private static SpeciesMareep? _instance = null;
#nullable restore
        public static SpeciesMareep Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMareep();
                }
                return _instance;
            }
        }

		#region SpeciesMareep Constructor
		public SpeciesMareep() : base(
			"Mareep",
			0.6,
			7.8,
			55, // HPs
			40, 40, // Attack & Defense
			65, 45, // Special Attack & Defense
			35		
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
				"Sand-Attack",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Thunder-Shock",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Agility",
				"Mimic",
				"Screech",
				"Double-Team",
				"Confuse-Ray",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Swift",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Cotton-Spore",
				"Protect",
				"Zap-Cannon",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Flatter",
				"Facade",
				"Charge",
				"Secret-Power",
				"Odor-Sleuth",
				"Signal-Beam",
				"Shock-Wave",
				"Natural-Gift",
				"Magnet-Rise",
				"Power-Gem",
				"Discharge",
				"Captivate",
				"Charge-Beam",
				"Electro-Ball",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Electroweb",
				"Wild-Charge",
				"Cotton-Guard",
				"Confide",
				"Eerie-Impulse",
				"Electric-Terrain"
			};
		}
		#endregion
	}
	#endregion

	//Mareep PokemonInstance Class
	#region Mareep
	public class MareepInstance : PokemonInstance
	{
		#region Mareep Constructors
		/// <summary>
		/// Mareep Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MareepInstance(string nickname, int level)
		: base(
				179,
				SpeciesMareep.Instance, // Pokemon Species
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mareep Builder only waiting for a Level
		/// </summary>
		public MareepInstance(int level)
		: base(
				179,
				SpeciesMareep.Instance, // PokemonInstance Species
				"Mareep", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mareep Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Mareep() : base(
			179,
			SpeciesMareep.Instance, // PokemonInstance Species
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
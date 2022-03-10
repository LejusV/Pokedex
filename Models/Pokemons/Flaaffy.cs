using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Flaaffy Species to store common natural stats of all Flaaffys
	#region SpeciesFlaaffy
	public class SpeciesFlaaffy : PokemonSpecies
	{
#nullable enable
		private static SpeciesFlaaffy? _instance = null;
#nullable restore
        public static SpeciesFlaaffy Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesFlaaffy();
                }
                return _instance;
            }
        }

		#region SpeciesFlaaffy Constructor
		public SpeciesFlaaffy() : base(
			"Flaaffy",
			0.8,
			13.3,
			70, // HPs
			55, 55, // Attack & Defense
			80, 60, // Special Attack & Defense
			45		
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
				"Mega-Punch",
				"Fire-Punch",
				"Thunder-Punch",
				"Mega-Kick",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Thunder-Shock",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Confuse-Ray",
				"Defense-Curl",
				"Light-Screen",
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
				"Dynamic-Punch",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Charge",
				"Brick-Break",
				"Secret-Power",
				"Signal-Beam",
				"Shock-Wave",
				"Natural-Gift",
				"Fling",
				"Magnet-Rise",
				"Power-Gem",
				"Discharge",
				"Captivate",
				"Charge-Beam",
				"Electro-Ball",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Volt-Switch",
				"Electroweb",
				"Wild-Charge",
				"Cotton-Guard",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Flaaffy PokemonInstance Class
	#region Flaaffy
	public class FlaaffyInstance : PokemonInstance
	{
		#region Flaaffy Constructors
		/// <summary>
		/// Flaaffy Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public FlaaffyInstance(string nickname, int level)
		: base(
				180,
				SpeciesFlaaffy.Instance, // Pokemon Species
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Flaaffy Builder only waiting for a Level
		/// </summary>
		public FlaaffyInstance(int level)
		: base(
				180,
				SpeciesFlaaffy.Instance, // PokemonInstance Species
				"Flaaffy", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Flaaffy Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Flaaffy() : base(
			180,
			SpeciesFlaaffy.Instance, // PokemonInstance Species
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
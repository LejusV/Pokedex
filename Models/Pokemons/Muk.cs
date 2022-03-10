using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Muk Species to store common natural stats of all Muks
	#region SpeciesMuk
	public class SpeciesMuk : PokemonSpecies
	{
#nullable enable
		private static SpeciesMuk? _instance = null;
#nullable restore
        public static SpeciesMuk Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMuk();
                }
                return _instance;
            }
        }

		#region SpeciesMuk Constructor
		public SpeciesMuk() : base(
			"Muk",
			1.2,
			30.0,
			105, // HPs
			105, 75, // Attack & Defense
			65, 100, // Special Attack & Defense
			50		
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Body-Slam",
				"Disable",
				"Flamethrower",
				"Hyper-Beam",
				"Strength",
				"Mega-Drain",
				"Thunderbolt",
				"Thunder",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Screech",
				"Double-Team",
				"Harden",
				"Minimize",
				"Bide",
				"Self-Destruct",
				"Sludge",
				"Fire-Blast",
				"Poison-Gas",
				"Acid-Armor",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Zap-Cannon",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Dynamic-Punch",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Rock-Smash",
				"Torment",
				"Memento",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Brick-Break",
				"Secret-Power",
				"Rock-Tomb",
				"Block",
				"Shock-Wave",
				"Natural-Gift",
				"Payback",
				"Fling",
				"Poison-Jab",
				"Dark-Pulse",
				"Focus-Blast",
				"Giga-Impact",
				"Mud-Bomb",
				"Gunk-Shot",
				"Captivate",
				"Venoshock",
				"Sludge-Wave",
				"Round",
				"Incinerate",
				"Belch",
				"Confide",
				"Venom-Drench",
				"Infestation",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Muk PokemonInstance Class
	#region Muk
	public class MukInstance : PokemonInstance
	{
		#region Muk Constructors
		/// <summary>
		/// Muk Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MukInstance(string nickname, int level)
		: base(
				89,
				SpeciesMuk.Instance, // Pokemon Species
				nickname, level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Muk Builder only waiting for a Level
		/// </summary>
		public MukInstance(int level)
		: base(
				89,
				SpeciesMuk.Instance, // PokemonInstance Species
				"Muk", level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Muk Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Muk() : base(
			89,
			SpeciesMuk.Instance, // PokemonInstance Species
			Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
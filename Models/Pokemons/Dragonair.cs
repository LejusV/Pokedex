using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Dragonair Species to store common natural stats of all Dragonairs
	#region SpeciesDragonair
	public class SpeciesDragonair : PokemonSpecies
	{
#nullable enable
		private static SpeciesDragonair? _instance = null;
#nullable restore
        public static SpeciesDragonair Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDragonair();
                }
                return _instance;
            }
        }

		#region SpeciesDragonair Constructor
		public SpeciesDragonair() : base(
			148,
			"Dragonair",
			4.0,
			16.5,
			61, // HPs
			84, 65, // Attack & Defense
			70, 70, // Special Attack & Defense
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
				"Bind",
				"Slam",
				"Headbutt",
				"Horn-Drill",
				"Body-Slam",
				"Wrap",
				"Take-Down",
				"Double-Edge",
				"Leer",
				"Flamethrower",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Dragon-Rage",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Agility",
				"Rage",
				"Mimic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Fire-Blast",
				"Waterfall",
				"Swift",
				"Skull-Bash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Zap-Cannon",
				"Icy-Wind",
				"Detect",
				"Outrage",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dragon-Breath",
				"Iron-Tail",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Whirlpool",
				"Hail",
				"Facade",
				"Secret-Power",
				"Dragon-Dance",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Dragon-Rush",
				"Draco-Meteor",
				"Captivate",
				"Round",
				"Incinerate",
				"Dragon-Tail",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Dragonair PokemonInstance Class
	#region Dragonair
	public class DragonairInstance : PokemonInstance
	{
		#region Dragonair Constructors
		/// <summary>
		/// Dragonair Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DragonairInstance(string nickname, int level)
		: base(
				SpeciesDragonair.Instance, // Pokemon Species
				nickname, level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dragonair Builder only waiting for a Level
		/// </summary>
		public DragonairInstance(int level)
		: base(
				SpeciesDragonair.Instance, // PokemonInstance Species
				"Dragonair", level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dragonair Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public DragonairInstance() : base(
			SpeciesDragonair.Instance, // PokemonInstance Species
			Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
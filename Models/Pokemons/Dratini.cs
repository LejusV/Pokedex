using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Dratini Species to store common natural stats of all Dratinis
	#region SpeciesDratini
	public class SpeciesDratini : PokemonSpecies
	{
#nullable enable
		private static SpeciesDratini? _instance = null;
#nullable restore
        public static SpeciesDratini Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDratini();
                }
                return _instance;
            }
        }

		#region SpeciesDratini Constructor
		public SpeciesDratini() : base(
			147,
			"Dratini",
			1.8,
			3.3,
			41, // HPs
			64, 45, // Attack & Defense
			50, 50, // Special Attack & Defense
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
				"Bind",
				"Slam",
				"Headbutt",
				"Body-Slam",
				"Wrap",
				"Take-Down",
				"Double-Edge",
				"Leer",
				"Supersonic",
				"Flamethrower",
				"Mist",
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
				"Haze",
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
				"Extreme-Speed",
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
				"Aqua-Jet",
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

	//Dratini PokemonInstance Class
	#region Dratini
	public class DratiniInstance : PokemonInstance
	{
		#region Dratini Constructors
		/// <summary>
		/// Dratini Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DratiniInstance(string nickname, int level)
		: base(
				SpeciesDratini.Instance, // Pokemon Species
				nickname, level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dratini Builder only waiting for a Level
		/// </summary>
		public DratiniInstance(int level)
		: base(
				SpeciesDratini.Instance, // PokemonInstance Species
				"Dratini", level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dratini Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public DratiniInstance() : base(
			SpeciesDratini.Instance, // PokemonInstance Species
			Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Dragonite Species to store common natural stats of all Dragonites
	#region SpeciesDragonite
	public class SpeciesDragonite : PokemonSpecies
	{
#nullable enable
		private static SpeciesDragonite? _instance = null;
#nullable restore
        public static SpeciesDragonite Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDragonite();
                }
                return _instance;
            }
        }

		#region SpeciesDragonite Constructor
		public SpeciesDragonite() : base(
			"Dragonite",
			2.2,
			210.0,
			91, // HPs
			134, 95, // Attack & Defense
			100, 100, // Special Attack & Defense
			80		
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Razor-Wind",
				"Cut",
				"Wing-Attack",
				"Fly",
				"Bind",
				"Slam",
				"Headbutt",
				"Horn-Drill",
				"Body-Slam",
				"Wrap",
				"Take-Down",
				"Double-Edge",
				"Leer",
				"Roar",
				"Flamethrower",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Strength",
				"Dragon-Rage",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
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
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Zap-Cannon",
				"Icy-Wind",
				"Detect",
				"Outrage",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dynamic-Punch",
				"Dragon-Breath",
				"Iron-Tail",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Whirlpool",
				"Heat-Wave",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Superpower",
				"Brick-Break",
				"Secret-Power",
				"Dive",
				"Air-Cutter",
				"Rock-Tomb",
				"Aerial-Ace",
				"Dragon-Claw",
				"Dragon-Dance",
				"Shock-Wave",
				"Water-Pulse",
				"Roost",
				"Natural-Gift",
				"Tailwind",
				"Fling",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Dragon-Rush",
				"Focus-Blast",
				"Giga-Impact",
				"Defog",
				"Draco-Meteor",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Ominous-Wind",
				"Hone-Claws",
				"Round",
				"Sky-Drop",
				"Incinerate",
				"Bulldoze",
				"Dragon-Tail",
				"Hurricane",
				"Confide",
				"Power-Up-Punch",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Dragonite PokemonInstance Class
	#region Dragonite
	public class DragoniteInstance : PokemonInstance
	{
		#region Dragonite Constructors
		/// <summary>
		/// Dragonite Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DragoniteInstance(string nickname, int level)
		: base(
				149,
				SpeciesDragonite.Instance, // Pokemon Species
				nickname, level,
				Dragon.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dragonite Builder only waiting for a Level
		/// </summary>
		public DragoniteInstance(int level)
		: base(
				149,
				SpeciesDragonite.Instance, // PokemonInstance Species
				"Dragonite", level,
				Dragon.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dragonite Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Dragonite() : base(
			149,
			SpeciesDragonite.Instance, // PokemonInstance Species
			Dragon.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
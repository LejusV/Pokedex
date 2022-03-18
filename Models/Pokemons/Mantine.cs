using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Mantine Species to store common natural stats of all Mantines
	#region SpeciesMantine
	public class SpeciesMantine : PokemonSpecies
	{
#nullable enable
		private static SpeciesMantine? _instance = null;
#nullable restore
        public static SpeciesMantine Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMantine();
                }
                return _instance;
            }
        }

		#region SpeciesMantine Constructor
		public SpeciesMantine() : base(
			226,
			"Mantine",
			2.1,
			220.0,
			85, // HPs
			40, 70, // Attack & Defense
			80, 140, // Special Attack & Defense
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
				"Wing-Attack",
				"Slam",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Supersonic",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Psybeam",
				"Bubble-Beam",
				"Hyper-Beam",
				"String-Shot",
				"Earthquake",
				"Toxic",
				"Agility",
				"Mimic",
				"Double-Team",
				"Confuse-Ray",
				"Haze",
				"Waterfall",
				"Swift",
				"Amnesia",
				"Bubble",
				"Splash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Mirror-Coat",
				"Whirlpool",
				"Hail",
				"Facade",
				"Helping-Hand",
				"Secret-Power",
				"Dive",
				"Mud-Sport",
				"Air-Cutter",
				"Rock-Tomb",
				"Signal-Beam",
				"Bullet-Seed",
				"Aerial-Ace",
				"Bounce",
				"Water-Sport",
				"Water-Pulse",
				"Roost",
				"Brine",
				"Natural-Gift",
				"Tailwind",
				"Aqua-Ring",
				"Aqua-Tail",
				"Seed-Bomb",
				"Air-Slash",
				"Giga-Impact",
				"Defog",
				"Gunk-Shot",
				"Iron-Head",
				"Captivate",
				"Wide-Guard",
				"Round",
				"Scald",
				"Acrobatics",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Mantine PokemonInstance Class
	#region Mantine
	public class MantineInstance : PokemonInstance
	{
		#region Mantine Constructors
		/// <summary>
		/// Mantine Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MantineInstance(string nickname, int level)
		: base(
				SpeciesMantine.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mantine Builder only waiting for a Level
		/// </summary>
		public MantineInstance(int level)
		: base(
				SpeciesMantine.Instance, // PokemonInstance Species
				"Mantine", level,
				Water.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mantine Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public MantineInstance() : base(
			SpeciesMantine.Instance, // PokemonInstance Species
			Water.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
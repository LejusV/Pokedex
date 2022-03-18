using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Kabutops Species to store common natural stats of all Kabutopss
	#region SpeciesKabutops
	public class SpeciesKabutops : PokemonSpecies
	{
#nullable enable
		private static SpeciesKabutops? _instance = null;
#nullable restore
        public static SpeciesKabutops Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesKabutops();
                }
                return _instance;
            }
        }

		#region SpeciesKabutops Constructor
		public SpeciesKabutops() : base(
			141,
			"Kabutops",
			1.3,
			40.5,
			60, // HPs
			115, 105, // Attack & Defense
			65, 70, // Special Attack & Defense
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
				"Scratch",
				"Razor-Wind",
				"Swords-Dance",
				"Cut",
				"Mega-Kick",
				"Sand-Attack",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Leer",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Submission",
				"Low-Kick",
				"Seismic-Toss",
				"Absorb",
				"Mega-Drain",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Harden",
				"Reflect",
				"Bide",
				"Waterfall",
				"Skull-Bash",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Sandstorm",
				"Giga-Drain",
				"Endure",
				"Rollout",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Ancient-Power",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Nature-Power",
				"Superpower",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Dive",
				"Rock-Tomb",
				"Metal-Sound",
				"Aerial-Ace",
				"Iron-Defense",
				"Mud-Shot",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Feint",
				"Wring-Out",
				"Rock-Polish",
				"Night-Slash",
				"Aqua-Tail",
				"X-Scissor",
				"Earth-Power",
				"Giga-Impact",
				"Rock-Climb",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Aqua-Jet",
				"Hone-Claws",
				"Smack-Down",
				"Round",
				"Scald",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Kabutops PokemonInstance Class
	#region Kabutops
	public class KabutopsInstance : PokemonInstance
	{
		#region Kabutops Constructors
		/// <summary>
		/// Kabutops Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public KabutopsInstance(string nickname, int level)
		: base(
				SpeciesKabutops.Instance, // Pokemon Species
				nickname, level,
				Rock.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kabutops Builder only waiting for a Level
		/// </summary>
		public KabutopsInstance(int level)
		: base(
				SpeciesKabutops.Instance, // PokemonInstance Species
				"Kabutops", level,
				Rock.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kabutops Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public KabutopsInstance() : base(
			SpeciesKabutops.Instance, // PokemonInstance Species
			Rock.Instance, Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
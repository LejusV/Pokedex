using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Kabuto Species to store common natural stats of all Kabutos
	#region SpeciesKabuto
	public class SpeciesKabuto : PokemonSpecies
	{
#nullable enable
		private static SpeciesKabuto? _instance = null;
#nullable restore
        public static SpeciesKabuto Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesKabuto();
                }
                return _instance;
            }
        }

		#region SpeciesKabuto Constructor
		public SpeciesKabuto() : base(
			"Kabuto",
			0.5,
			11.5,
			30, // HPs
			80, 90, // Attack & Defense
			55, 45, // Special Attack & Defense
			55		
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
				"Sand-Attack",
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
				"Aurora-Beam",
				"Absorb",
				"Mega-Drain",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Screech",
				"Double-Team",
				"Harden",
				"Confuse-Ray",
				"Reflect",
				"Bide",
				"Waterfall",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Mud-Slap",
				"Foresight",
				"Icy-Wind",
				"Sandstorm",
				"Giga-Drain",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Rapid-Spin",
				"Hidden-Power",
				"Rain-Dance",
				"Ancient-Power",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Knock-Off",
				"Secret-Power",
				"Rock-Tomb",
				"Metal-Sound",
				"Aerial-Ace",
				"Iron-Defense",
				"Mud-Shot",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Wring-Out",
				"Rock-Polish",
				"Earth-Power",
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

	//Kabuto PokemonInstance Class
	#region Kabuto
	public class KabutoInstance : PokemonInstance
	{
		#region Kabuto Constructors
		/// <summary>
		/// Kabuto Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public KabutoInstance(string nickname, int level)
		: base(
				140,
				SpeciesKabuto.Instance, // Pokemon Species
				nickname, level,
				Rock.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kabuto Builder only waiting for a Level
		/// </summary>
		public KabutoInstance(int level)
		: base(
				140,
				SpeciesKabuto.Instance, // PokemonInstance Species
				"Kabuto", level,
				Rock.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kabuto Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Kabuto() : base(
			140,
			SpeciesKabuto.Instance, // PokemonInstance Species
			Rock.Instance, Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
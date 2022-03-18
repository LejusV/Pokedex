using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Jigglypuff Species to store common natural stats of all Jigglypuffs
	#region SpeciesJigglypuff
	public class SpeciesJigglypuff : PokemonSpecies
	{
#nullable enable
		private static SpeciesJigglypuff? _instance = null;
#nullable restore
        public static SpeciesJigglypuff Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesJigglypuff();
                }
                return _instance;
            }
        }

		#region SpeciesJigglypuff Constructor
		public SpeciesJigglypuff() : base(
			39,
			"Jigglypuff",
			0.5,
			5.5,
			115, // HPs
			45, 20, // Attack & Defense
			45, 25, // Special Attack & Defense
			20		
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
				"Double-Slap",
				"Mega-Punch",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Sing",
				"Disable",
				"Flamethrower",
				"Water-Gun",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Submission",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Dig",
				"Toxic",
				"Psychic",
				"Rage",
				"Teleport",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Fire-Blast",
				"Skull-Bash",
				"Dream-Eater",
				"Flash",
				"Psywave",
				"Rest",
				"Tri-Attack",
				"Substitute",
				"Nightmare",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Zap-Cannon",
				"Icy-Wind",
				"Detect",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Pain-Split",
				"Dynamic-Punch",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Role-Play",
				"Magic-Coat",
				"Recycle",
				"Brick-Break",
				"Knock-Off",
				"Endeavor",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Bounce",
				"Covet",
				"Shock-Wave",
				"Water-Pulse",
				"Gravity",
				"Wake-Up-Slap",
				"Gyro-Ball",
				"Natural-Gift",
				"Fling",
				"Last-Resort",
				"Drain-Punch",
				"Captivate",
				"Stealth-Rock",
				"Grass-Knot",
				"Charge-Beam",
				"Round",
				"Echoed-Voice",
				"Incinerate",
				"Retaliate",
				"Work-Up",
				"Wild-Charge",
				"Disarming-Voice",
				"Play-Nice",
				"Confide",
				"Dazzling-Gleam",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Jigglypuff PokemonInstance Class
	#region Jigglypuff
	public class JigglypuffInstance : PokemonInstance
	{
		#region Jigglypuff Constructors
		/// <summary>
		/// Jigglypuff Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public JigglypuffInstance(string nickname, int level)
		: base(
				SpeciesJigglypuff.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Jigglypuff Builder only waiting for a Level
		/// </summary>
		public JigglypuffInstance(int level)
		: base(
				SpeciesJigglypuff.Instance, // PokemonInstance Species
				"Jigglypuff", level,
				Normal.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Jigglypuff Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public JigglypuffInstance() : base(
			SpeciesJigglypuff.Instance, // PokemonInstance Species
			Normal.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Poliwhirl Species to store common natural stats of all Poliwhirls
	#region SpeciesPoliwhirl
	public class SpeciesPoliwhirl : PokemonSpecies
	{
#nullable enable
		private static SpeciesPoliwhirl? _instance = null;
#nullable restore
        public static SpeciesPoliwhirl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPoliwhirl();
                }
                return _instance;
            }
        }

		#region SpeciesPoliwhirl Constructor
		public SpeciesPoliwhirl() : base(
			61,
			"Poliwhirl",
			1.0,
			20.0,
			65, // HPs
			65, 65, // Attack & Defense
			50, 50, // Special Attack & Defense
			90		
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
				"Double-Slap",
				"Mega-Punch",
				"Ice-Punch",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Submission",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Psychic",
				"Hypnosis",
				"Rage",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Bide",
				"Metronome",
				"Waterfall",
				"Skull-Bash",
				"Amnesia",
				"Bubble",
				"Psywave",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Belly-Drum",
				"Mud-Slap",
				"Icy-Wind",
				"Detect",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Dive",
				"Mud-Shot",
				"Water-Sport",
				"Water-Pulse",
				"Wake-Up-Slap",
				"Natural-Gift",
				"Fling",
				"Mud-Bomb",
				"Captivate",
				"Round",
				"Scald",
				"Bulldoze",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Poliwhirl PokemonInstance Class
	#region Poliwhirl
	public class PoliwhirlInstance : PokemonInstance
	{
		#region Poliwhirl Constructors
		/// <summary>
		/// Poliwhirl Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PoliwhirlInstance(string nickname, int level)
		: base(
				SpeciesPoliwhirl.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Poliwhirl Builder only waiting for a Level
		/// </summary>
		public PoliwhirlInstance(int level)
		: base(
				SpeciesPoliwhirl.Instance, // PokemonInstance Species
				"Poliwhirl", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Poliwhirl Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public PoliwhirlInstance() : base(
			SpeciesPoliwhirl.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
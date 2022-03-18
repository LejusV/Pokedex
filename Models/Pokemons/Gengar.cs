using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Gengar Species to store common natural stats of all Gengars
	#region SpeciesGengar
	public class SpeciesGengar : PokemonSpecies
	{
#nullable enable
		private static SpeciesGengar? _instance = null;
#nullable restore
        public static SpeciesGengar Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGengar();
                }
                return _instance;
            }
        }

		#region SpeciesGengar Constructor
		public SpeciesGengar() : base(
			94,
			"Gengar",
			1.5,
			40.5,
			60, // HPs
			65, 60, // Attack & Defense
			130, 75, // Special Attack & Defense
			110		
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
				"Ice-Punch",
				"Thunder-Punch",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Hyper-Beam",
				"Submission",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Mega-Drain",
				"Thunderbolt",
				"Thunder",
				"Toxic",
				"Psychic",
				"Hypnosis",
				"Rage",
				"Night-Shade",
				"Mimic",
				"Double-Team",
				"Confuse-Ray",
				"Bide",
				"Metronome",
				"Self-Destruct",
				"Lick",
				"Skull-Bash",
				"Dream-Eater",
				"Psywave",
				"Explosion",
				"Rest",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Sludge-Bomb",
				"Zap-Cannon",
				"Destiny-Bond",
				"Icy-Wind",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Mean-Look",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Dynamic-Punch",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Uproar",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Trick",
				"Role-Play",
				"Brick-Break",
				"Knock-Off",
				"Skill-Swap",
				"Snatch",
				"Secret-Power",
				"Shadow-Punch",
				"Natural-Gift",
				"Payback",
				"Embargo",
				"Fling",
				"Sucker-Punch",
				"Poison-Jab",
				"Dark-Pulse",
				"Drain-Punch",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Shadow-Claw",
				"Trick-Room",
				"Captivate",
				"Ominous-Wind",
				"Wonder-Room",
				"Venoshock",
				"Telekinesis",
				"Foul-Play",
				"Round",
				"Hex",
				"Confide",
				"Dazzling-Gleam",
				"Infestation",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Gengar PokemonInstance Class
	#region Gengar
	public class GengarInstance : PokemonInstance
	{
		#region Gengar Constructors
		/// <summary>
		/// Gengar Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GengarInstance(string nickname, int level)
		: base(
				SpeciesGengar.Instance, // Pokemon Species
				nickname, level,
				Ghost.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gengar Builder only waiting for a Level
		/// </summary>
		public GengarInstance(int level)
		: base(
				SpeciesGengar.Instance, // PokemonInstance Species
				"Gengar", level,
				Ghost.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gengar Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public GengarInstance() : base(
			SpeciesGengar.Instance, // PokemonInstance Species
			Ghost.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
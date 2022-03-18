using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Jynx Species to store common natural stats of all Jynxs
	#region SpeciesJynx
	public class SpeciesJynx : PokemonSpecies
	{
#nullable enable
		private static SpeciesJynx? _instance = null;
#nullable restore
        public static SpeciesJynx Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesJynx();
                }
                return _instance;
            }
        }

		#region SpeciesJynx Constructor
		public SpeciesJynx() : base(
			124,
			"Jynx",
			1.4,
			40.6,
			65, // HPs
			50, 35, // Attack & Defense
			115, 95, // Special Attack & Defense
			95		
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
				"Ice-Punch",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Water-Gun",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Submission",
				"Counter",
				"Seismic-Toss",
				"Toxic",
				"Psychic",
				"Rage",
				"Teleport",
				"Mimic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Metronome",
				"Lick",
				"Skull-Bash",
				"Dream-Eater",
				"Lovely-Kiss",
				"Flash",
				"Psywave",
				"Rest",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Powder-Snow",
				"Protect",
				"Mud-Slap",
				"Perish-Song",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Mean-Look",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Sweet-Scent",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Shadow-Ball",
				"Hail",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Helping-Hand",
				"Trick",
				"Role-Play",
				"Magic-Coat",
				"Recycle",
				"Brick-Break",
				"Skill-Swap",
				"Secret-Power",
				"Hyper-Voice",
				"Fake-Tears",
				"Signal-Beam",
				"Covet",
				"Calm-Mind",
				"Water-Pulse",
				"Wake-Up-Slap",
				"Natural-Gift",
				"Payback",
				"Fling",
				"Wring-Out",
				"Drain-Punch",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Avalanche",
				"Zen-Headbutt",
				"Trick-Room",
				"Captivate",
				"Grass-Knot",
				"Psyshock",
				"Telekinesis",
				"Magic-Room",
				"Round",
				"Echoed-Voice",
				"Frost-Breath",
				"Heart-Stamp",
				"Draining-Kiss",
				"Confide",
				"Power-Up-Punch",
				"Aurora-Veil"
			};
		}
		#endregion
	}
	#endregion

	//Jynx PokemonInstance Class
	#region Jynx
	public class JynxInstance : PokemonInstance
	{
		#region Jynx Constructors
		/// <summary>
		/// Jynx Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public JynxInstance(string nickname, int level)
		: base(
				SpeciesJynx.Instance, // Pokemon Species
				nickname, level,
				Ice.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Jynx Builder only waiting for a Level
		/// </summary>
		public JynxInstance(int level)
		: base(
				SpeciesJynx.Instance, // PokemonInstance Species
				"Jynx", level,
				Ice.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Jynx Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public JynxInstance() : base(
			SpeciesJynx.Instance, // PokemonInstance Species
			Ice.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
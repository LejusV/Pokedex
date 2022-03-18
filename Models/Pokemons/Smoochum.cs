using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Smoochum Species to store common natural stats of all Smoochums
	#region SpeciesSmoochum
	public class SpeciesSmoochum : PokemonSpecies
	{
#nullable enable
		private static SpeciesSmoochum? _instance = null;
#nullable restore
        public static SpeciesSmoochum Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSmoochum();
                }
                return _instance;
            }
        }

		#region SpeciesSmoochum Constructor
		public SpeciesSmoochum() : base(
			238,
			"Smoochum",
			0.4,
			6.0,
			45, // HPs
			30, 15, // Attack & Defense
			85, 65, // Special Attack & Defense
			65		
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
				"Mega-Punch",
				"Ice-Punch",
				"Mega-Kick",
				"Body-Slam",
				"Double-Edge",
				"Sing",
				"Ice-Beam",
				"Blizzard",
				"Counter",
				"Seismic-Toss",
				"Toxic",
				"Confusion",
				"Psychic",
				"Meditate",
				"Mimic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Metronome",
				"Lick",
				"Dream-Eater",
				"Lovely-Kiss",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Powder-Snow",
				"Protect",
				"Sweet-Kiss",
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
				"Fake-Out",
				"Uproar",
				"Hail",
				"Facade",
				"Helping-Hand",
				"Trick",
				"Role-Play",
				"Wish",
				"Magic-Coat",
				"Recycle",
				"Skill-Swap",
				"Secret-Power",
				"Fake-Tears",
				"Signal-Beam",
				"Covet",
				"Calm-Mind",
				"Water-Pulse",
				"Miracle-Eye",
				"Wake-Up-Slap",
				"Natural-Gift",
				"Payback",
				"Fling",
				"Lucky-Chant",
				"Copycat",
				"Nasty-Plot",
				"Avalanche",
				"Zen-Headbutt",
				"Trick-Room",
				"Captivate",
				"Grass-Knot",
				"Psyshock",
				"Magic-Room",
				"Round",
				"Echoed-Voice",
				"Frost-Breath",
				"Heart-Stamp",
				"Confide",
				"Aurora-Veil"
			};
		}
		#endregion
	}
	#endregion

	//Smoochum PokemonInstance Class
	#region Smoochum
	public class SmoochumInstance : PokemonInstance
	{
		#region Smoochum Constructors
		/// <summary>
		/// Smoochum Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SmoochumInstance(string nickname, int level)
		: base(
				SpeciesSmoochum.Instance, // Pokemon Species
				nickname, level,
				Ice.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Smoochum Builder only waiting for a Level
		/// </summary>
		public SmoochumInstance(int level)
		: base(
				SpeciesSmoochum.Instance, // PokemonInstance Species
				"Smoochum", level,
				Ice.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Smoochum Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SmoochumInstance() : base(
			SpeciesSmoochum.Instance, // PokemonInstance Species
			Ice.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
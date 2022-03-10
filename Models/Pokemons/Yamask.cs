using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Yamask Species to store common natural stats of all Yamasks
	#region SpeciesYamask
	public class SpeciesYamask : PokemonSpecies
	{
#nullable enable
		private static SpeciesYamask? _instance = null;
#nullable restore
        public static SpeciesYamask Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesYamask();
                }
                return _instance;
            }
        }

		#region SpeciesYamask Constructor
		public SpeciesYamask() : base(
			"Yamask",
			0.5,
			1.5,
			38, // HPs
			30, 85, // Attack & Defense
			55, 65, // Special Attack & Defense
			30		
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
				"Disable",
				"Toxic",
				"Psychic",
				"Night-Shade",
				"Double-Team",
				"Haze",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Destiny-Bond",
				"Endure",
				"Swagger",
				"Mean-Look",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Pain-Split",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Shadow-Ball",
				"Will-O-Wisp",
				"Memento",
				"Facade",
				"Trick",
				"Role-Play",
				"Magic-Coat",
				"Knock-Off",
				"Skill-Swap",
				"Imprison",
				"Grudge",
				"Snatch",
				"Secret-Power",
				"Astonish",
				"Fake-Tears",
				"Iron-Defense",
				"Block",
				"Calm-Mind",
				"Shock-Wave",
				"Payback",
				"Embargo",
				"Heal-Block",
				"Toxic-Spikes",
				"Dark-Pulse",
				"Energy-Ball",
				"Nasty-Plot",
				"Zen-Headbutt",
				"Trick-Room",
				"Ominous-Wind",
				"Guard-Split",
				"Power-Split",
				"Wonder-Room",
				"Telekinesis",
				"After-You",
				"Round",
				"Ally-Switch",
				"Hex",
				"Crafty-Shield",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Yamask PokemonInstance Class
	#region Yamask
	public class YamaskInstance : PokemonInstance
	{
		#region Yamask Constructors
		/// <summary>
		/// Yamask Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public YamaskInstance(string nickname, int level)
		: base(
				562,
				SpeciesYamask.Instance, // Pokemon Species
				nickname, level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Yamask Builder only waiting for a Level
		/// </summary>
		public YamaskInstance(int level)
		: base(
				562,
				SpeciesYamask.Instance, // PokemonInstance Species
				"Yamask", level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Yamask Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Yamask() : base(
			562,
			SpeciesYamask.Instance, // PokemonInstance Species
			Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
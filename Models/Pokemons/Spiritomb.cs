using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Spiritomb Species to store common natural stats of all Spiritombs
	#region SpeciesSpiritomb
	public class SpeciesSpiritomb : PokemonSpecies
	{
#nullable enable
		private static SpeciesSpiritomb? _instance = null;
#nullable restore
        public static SpeciesSpiritomb Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSpiritomb();
                }
                return _instance;
            }
        }

		#region SpeciesSpiritomb Constructor
		public SpeciesSpiritomb() : base(
			442,
			"Spiritomb",
			1.0,
			108.0,
			50, // HPs
			92, 108, // Attack & Defense
			92, 108, // Special Attack & Defense
			35		
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
				"Hyper-Beam",
				"Toxic",
				"Psychic",
				"Hypnosis",
				"Double-Team",
				"Smokescreen",
				"Confuse-Ray",
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
				"Feint-Attack",
				"Destiny-Bond",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Uproar",
				"Torment",
				"Will-O-Wisp",
				"Memento",
				"Facade",
				"Taunt",
				"Trick",
				"Imprison",
				"Grudge",
				"Snatch",
				"Secret-Power",
				"Rock-Tomb",
				"Silver-Wind",
				"Calm-Mind",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Embargo",
				"Sucker-Punch",
				"Dark-Pulse",
				"Giga-Impact",
				"Nasty-Plot",
				"Shadow-Sneak",
				"Captivate",
				"Ominous-Wind",
				"Wonder-Room",
				"Telekinesis",
				"Foul-Play",
				"Round",
				"Quash",
				"Retaliate",
				"Snarl",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Spiritomb PokemonInstance Class
	#region Spiritomb
	public class SpiritombInstance : PokemonInstance
	{
		#region Spiritomb Constructors
		/// <summary>
		/// Spiritomb Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SpiritombInstance(string nickname, int level)
		: base(
				SpeciesSpiritomb.Instance, // Pokemon Species
				nickname, level,
				Ghost.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spiritomb Builder only waiting for a Level
		/// </summary>
		public SpiritombInstance(int level)
		: base(
				SpeciesSpiritomb.Instance, // PokemonInstance Species
				"Spiritomb", level,
				Ghost.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spiritomb Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SpiritombInstance() : base(
			SpeciesSpiritomb.Instance, // PokemonInstance Species
			Ghost.Instance, Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
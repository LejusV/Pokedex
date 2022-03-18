using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Chingling Species to store common natural stats of all Chinglings
	#region SpeciesChingling
	public class SpeciesChingling : PokemonSpecies
	{
#nullable enable
		private static SpeciesChingling? _instance = null;
#nullable restore
        public static SpeciesChingling Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesChingling();
                }
                return _instance;
            }
        }

		#region SpeciesChingling Constructor
		public SpeciesChingling() : base(
			433,
			"Chingling",
			0.2,
			0.6,
			45, // HPs
			30, 50, // Attack & Defense
			65, 50, // Special Attack & Defense
			45		
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
				"Bind",
				"Wrap",
				"Growl",
				"Disable",
				"Thunder-Wave",
				"Toxic",
				"Confusion",
				"Psychic",
				"Hypnosis",
				"Double-Team",
				"Recover",
				"Light-Screen",
				"Reflect",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Icy-Wind",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Future-Sight",
				"Uproar",
				"Torment",
				"Facade",
				"Taunt",
				"Helping-Hand",
				"Trick",
				"Wish",
				"Magic-Coat",
				"Recycle",
				"Yawn",
				"Knock-Off",
				"Skill-Swap",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Astonish",
				"Cosmic-Power",
				"Signal-Beam",
				"Calm-Mind",
				"Shock-Wave",
				"Gravity",
				"Natural-Gift",
				"Last-Resort",
				"Zen-Headbutt",
				"Trick-Room",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Psyshock",
				"Telekinesis",
				"Entrainment",
				"Round",
				"Echoed-Voice",
				"Stored-Power",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion

	//Chingling PokemonInstance Class
	#region Chingling
	public class ChinglingInstance : PokemonInstance
	{
		#region Chingling Constructors
		/// <summary>
		/// Chingling Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ChinglingInstance(string nickname, int level)
		: base(
				SpeciesChingling.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chingling Builder only waiting for a Level
		/// </summary>
		public ChinglingInstance(int level)
		: base(
				SpeciesChingling.Instance, // PokemonInstance Species
				"Chingling", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chingling Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ChinglingInstance() : base(
			SpeciesChingling.Instance, // PokemonInstance Species
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
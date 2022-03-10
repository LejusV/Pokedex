using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Malamar Species to store common natural stats of all Malamars
	#region SpeciesMalamar
	public class SpeciesMalamar : PokemonSpecies
	{
#nullable enable
		private static SpeciesMalamar? _instance = null;
#nullable restore
        public static SpeciesMalamar Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMalamar();
                }
                return _instance;
            }
        }

		#region SpeciesMalamar Constructor
		public SpeciesMalamar() : base(
			"Malamar",
			1.5,
			47.0,
			86, // HPs
			92, 88, // Attack & Defense
			68, 75, // Special Attack & Defense
			73		
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
				"Cut",
				"Bind",
				"Tackle",
				"Flamethrower",
				"Psybeam",
				"Hyper-Beam",
				"Peck",
				"Thunderbolt",
				"Toxic",
				"Psychic",
				"Hypnosis",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Constrict",
				"Flash",
				"Psywave",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Reversal",
				"Spite",
				"Protect",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Torment",
				"Facade",
				"Taunt",
				"Role-Play",
				"Superpower",
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Signal-Beam",
				"Aerial-Ace",
				"Block",
				"Calm-Mind",
				"Pluck",
				"Payback",
				"Embargo",
				"Fling",
				"Dark-Pulse",
				"Night-Slash",
				"Switcheroo",
				"Giga-Impact",
				"Psycho-Cut",
				"Trick-Room",
				"Psyshock",
				"Foul-Play",
				"Round",
				"Retaliate",
				"Topsy-Turvy",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Malamar PokemonInstance Class
	#region Malamar
	public class MalamarInstance : PokemonInstance
	{
		#region Malamar Constructors
		/// <summary>
		/// Malamar Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MalamarInstance(string nickname, int level)
		: base(
				687,
				SpeciesMalamar.Instance, // Pokemon Species
				nickname, level,
				Dark.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Malamar Builder only waiting for a Level
		/// </summary>
		public MalamarInstance(int level)
		: base(
				687,
				SpeciesMalamar.Instance, // PokemonInstance Species
				"Malamar", level,
				Dark.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Malamar Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Malamar() : base(
			687,
			SpeciesMalamar.Instance, // PokemonInstance Species
			Dark.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
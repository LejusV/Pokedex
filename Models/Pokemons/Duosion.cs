using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Duosion Species to store common natural stats of all Duosions
	#region SpeciesDuosion
	public class SpeciesDuosion : PokemonSpecies
	{
#nullable enable
		private static SpeciesDuosion? _instance = null;
#nullable restore
        public static SpeciesDuosion Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDuosion();
                }
                return _instance;
            }
        }

		#region SpeciesDuosion Constructor
		public SpeciesDuosion() : base(
			"Duosion",
			0.6,
			8.0,
			65, // HPs
			40, 50, // Attack & Defense
			125, 60, // Special Attack & Defense
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
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Recover",
				"Light-Screen",
				"Reflect",
				"Dream-Eater",
				"Flash",
				"Psywave",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Charm",
				"Rollout",
				"Swagger",
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
				"Future-Sight",
				"Facade",
				"Helping-Hand",
				"Trick",
				"Role-Play",
				"Magic-Coat",
				"Endeavor",
				"Skill-Swap",
				"Snatch",
				"Secret-Power",
				"Rock-Tomb",
				"Signal-Beam",
				"Iron-Defense",
				"Calm-Mind",
				"Shock-Wave",
				"Gravity",
				"Gyro-Ball",
				"Embargo",
				"Heal-Block",
				"Energy-Ball",
				"Zen-Headbutt",
				"Flash-Cannon",
				"Trick-Room",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"After-You",
				"Round",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Duosion PokemonInstance Class
	#region Duosion
	public class DuosionInstance : PokemonInstance
	{
		#region Duosion Constructors
		/// <summary>
		/// Duosion Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DuosionInstance(string nickname, int level)
		: base(
				578,
				SpeciesDuosion.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Duosion Builder only waiting for a Level
		/// </summary>
		public DuosionInstance(int level)
		: base(
				578,
				SpeciesDuosion.Instance, // PokemonInstance Species
				"Duosion", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Duosion Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Duosion() : base(
			578,
			SpeciesDuosion.Instance, // PokemonInstance Species
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Solosis Species to store common natural stats of all Solosiss
	#region SpeciesSolosis
	public class SpeciesSolosis : PokemonSpecies
	{
#nullable enable
		private static SpeciesSolosis? _instance = null;
#nullable restore
        public static SpeciesSolosis Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSolosis();
                }
                return _instance;
            }
        }

		#region SpeciesSolosis Constructor
		public SpeciesSolosis() : base(
			577,
			"Solosis",
			0.3,
			1.0,
			45, // HPs
			30, 40, // Attack & Defense
			105, 50, // Special Attack & Defense
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
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Psychic",
				"Night-Shade",
				"Double-Team",
				"Recover",
				"Confuse-Ray",
				"Light-Screen",
				"Reflect",
				"Dream-Eater",
				"Flash",
				"Psywave",
				"Acid-Armor",
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
				"Imprison",
				"Snatch",
				"Secret-Power",
				"Astonish",
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

	//Solosis PokemonInstance Class
	#region Solosis
	public class SolosisInstance : PokemonInstance
	{
		#region Solosis Constructors
		/// <summary>
		/// Solosis Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SolosisInstance(string nickname, int level)
		: base(
				SpeciesSolosis.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Solosis Builder only waiting for a Level
		/// </summary>
		public SolosisInstance(int level)
		: base(
				SpeciesSolosis.Instance, // PokemonInstance Species
				"Solosis", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Solosis Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SolosisInstance() : base(
			SpeciesSolosis.Instance, // PokemonInstance Species
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Reuniclus Species to store common natural stats of all Reunicluss
	#region SpeciesReuniclus
	public class SpeciesReuniclus : PokemonSpecies
	{
#nullable enable
		private static SpeciesReuniclus? _instance = null;
#nullable restore
        public static SpeciesReuniclus Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesReuniclus();
                }
                return _instance;
            }
        }

		#region SpeciesReuniclus Constructor
		public SpeciesReuniclus() : base(
			579,
			"Reuniclus",
			1.0,
			20.1,
			110, // HPs
			65, 75, // Attack & Defense
			125, 85, // Special Attack & Defense
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Hyper-Beam",
				"Strength",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Recover",
				"Light-Screen",
				"Reflect",
				"Dream-Eater",
				"Dizzy-Punch",
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
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Trick",
				"Role-Play",
				"Superpower",
				"Magic-Coat",
				"Knock-Off",
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
				"Fling",
				"Heal-Block",
				"Drain-Punch",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Zen-Headbutt",
				"Flash-Cannon",
				"Trick-Room",
				"Grass-Knot",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"After-You",
				"Round",
				"Confide",
				"Infestation",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Reuniclus PokemonInstance Class
	#region Reuniclus
	public class ReuniclusInstance : PokemonInstance
	{
		#region Reuniclus Constructors
		/// <summary>
		/// Reuniclus Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ReuniclusInstance(string nickname, int level)
		: base(
				SpeciesReuniclus.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Reuniclus Builder only waiting for a Level
		/// </summary>
		public ReuniclusInstance(int level)
		: base(
				SpeciesReuniclus.Instance, // PokemonInstance Species
				"Reuniclus", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Reuniclus Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ReuniclusInstance() : base(
			SpeciesReuniclus.Instance, // PokemonInstance Species
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
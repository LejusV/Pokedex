using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Gothitelle Species to store common natural stats of all Gothitelles
	#region SpeciesGothitelle
	public class SpeciesGothitelle : PokemonSpecies
	{
#nullable enable
		private static SpeciesGothitelle? _instance = null;
#nullable restore
        public static SpeciesGothitelle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGothitelle();
                }
                return _instance;
            }
        }

		#region SpeciesGothitelle Constructor
		public SpeciesGothitelle() : base(
			"Gothitelle",
			1.5,
			44.0,
			70, // HPs
			55, 95, // Attack & Defense
			95, 110, // Special Attack & Defense
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
				"Double-Slap",
				"Psybeam",
				"Hyper-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Toxic",
				"Confusion",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Feint-Attack",
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Shadow-Ball",
				"Future-Sight",
				"Uproar",
				"Torment",
				"Flatter",
				"Facade",
				"Taunt",
				"Helping-Hand",
				"Trick",
				"Role-Play",
				"Magic-Coat",
				"Recycle",
				"Brick-Break",
				"Skill-Swap",
				"Snatch",
				"Secret-Power",
				"Fake-Tears",
				"Rock-Tomb",
				"Tickle",
				"Signal-Beam",
				"Covet",
				"Calm-Mind",
				"Shock-Wave",
				"Gravity",
				"Payback",
				"Embargo",
				"Fling",
				"Heal-Block",
				"Dark-Pulse",
				"Energy-Ball",
				"Giga-Impact",
				"Zen-Headbutt",
				"Trick-Room",
				"Grass-Knot",
				"Charge-Beam",
				"Psyshock",
				"Telekinesis",
				"Magic-Room",
				"Low-Sweep",
				"Foul-Play",
				"Round",
				"Play-Nice",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Gothitelle PokemonInstance Class
	#region Gothitelle
	public class GothitelleInstance : PokemonInstance
	{
		#region Gothitelle Constructors
		/// <summary>
		/// Gothitelle Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GothitelleInstance(string nickname, int level)
		: base(
				576,
				SpeciesGothitelle.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gothitelle Builder only waiting for a Level
		/// </summary>
		public GothitelleInstance(int level)
		: base(
				576,
				SpeciesGothitelle.Instance, // PokemonInstance Species
				"Gothitelle", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gothitelle Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Gothitelle() : base(
			576,
			SpeciesGothitelle.Instance, // PokemonInstance Species
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
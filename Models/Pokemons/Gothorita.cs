using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Gothorita Species to store common natural stats of all Gothoritas
	#region SpeciesGothorita
	public class SpeciesGothorita : PokemonSpecies
	{
#nullable enable
		private static SpeciesGothorita? _instance = null;
#nullable restore
        public static SpeciesGothorita Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGothorita();
                }
                return _instance;
            }
        }

		#region SpeciesGothorita Constructor
		public SpeciesGothorita() : base(
			575,
			"Gothorita",
			0.7,
			18.0,
			60, // HPs
			45, 70, // Attack & Defense
			75, 85, // Special Attack & Defense
			55		
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
				"Zen-Headbutt",
				"Trick-Room",
				"Grass-Knot",
				"Charge-Beam",
				"Psyshock",
				"Telekinesis",
				"Magic-Room",
				"Foul-Play",
				"Round",
				"Play-Nice",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Gothorita PokemonInstance Class
	#region Gothorita
	public class GothoritaInstance : PokemonInstance
	{
		#region Gothorita Constructors
		/// <summary>
		/// Gothorita Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GothoritaInstance(string nickname, int level)
		: base(
				SpeciesGothorita.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gothorita Builder only waiting for a Level
		/// </summary>
		public GothoritaInstance(int level)
		: base(
				SpeciesGothorita.Instance, // PokemonInstance Species
				"Gothorita", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gothorita Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public GothoritaInstance() : base(
			SpeciesGothorita.Instance, // PokemonInstance Species
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
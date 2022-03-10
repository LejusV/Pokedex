using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Gothita Species to store common natural stats of all Gothitas
	#region SpeciesGothita
	public class SpeciesGothita : PokemonSpecies
	{
#nullable enable
		private static SpeciesGothita? _instance = null;
#nullable restore
        public static SpeciesGothita Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGothita();
                }
                return _instance;
            }
        }

		#region SpeciesGothita Constructor
		public SpeciesGothita() : base(
			"Gothita",
			0.4,
			5.8,
			45, // HPs
			30, 50, // Attack & Defense
			55, 65, // Special Attack & Defense
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
				"Mean-Look",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Mirror-Coat",
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
				"Miracle-Eye",
				"Payback",
				"Embargo",
				"Fling",
				"Heal-Block",
				"Dark-Pulse",
				"Energy-Ball",
				"Zen-Headbutt",
				"Trick-Room",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Psyshock",
				"Telekinesis",
				"Magic-Room",
				"Foul-Play",
				"Round",
				"Heal-Pulse",
				"Play-Nice",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Gothita PokemonInstance Class
	#region Gothita
	public class GothitaInstance : PokemonInstance
	{
		#region Gothita Constructors
		/// <summary>
		/// Gothita Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GothitaInstance(string nickname, int level)
		: base(
				574,
				SpeciesGothita.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gothita Builder only waiting for a Level
		/// </summary>
		public GothitaInstance(int level)
		: base(
				574,
				SpeciesGothita.Instance, // PokemonInstance Species
				"Gothita", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gothita Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Gothita() : base(
			574,
			SpeciesGothita.Instance, // PokemonInstance Species
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Lampent Species to store common natural stats of all Lampents
	#region SpeciesLampent
	public class SpeciesLampent : PokemonSpecies
	{
#nullable enable
		private static SpeciesLampent? _instance = null;
#nullable restore
        public static SpeciesLampent Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesLampent();
                }
                return _instance;
            }
        }

		#region SpeciesLampent Constructor
		public SpeciesLampent() : base(
			608,
			"Lampent",
			0.6,
			13.0,
			60, // HPs
			40, 60, // Attack & Defense
			95, 60, // Special Attack & Defense
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
				"Ember",
				"Flamethrower",
				"Solar-Beam",
				"Fire-Spin",
				"Toxic",
				"Psychic",
				"Night-Shade",
				"Double-Team",
				"Minimize",
				"Confuse-Ray",
				"Smog",
				"Fire-Blast",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Pain-Split",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Heat-Wave",
				"Will-O-Wisp",
				"Memento",
				"Facade",
				"Taunt",
				"Trick",
				"Imprison",
				"Secret-Power",
				"Astonish",
				"Overheat",
				"Calm-Mind",
				"Shock-Wave",
				"Payback",
				"Embargo",
				"Dark-Pulse",
				"Energy-Ball",
				"Trick-Room",
				"Telekinesis",
				"Flame-Burst",
				"Flame-Charge",
				"Round",
				"Hex",
				"Incinerate",
				"Inferno",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Lampent PokemonInstance Class
	#region Lampent
	public class LampentInstance : PokemonInstance
	{
		#region Lampent Constructors
		/// <summary>
		/// Lampent Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public LampentInstance(string nickname, int level)
		: base(
				SpeciesLampent.Instance, // Pokemon Species
				nickname, level,
				Ghost.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lampent Builder only waiting for a Level
		/// </summary>
		public LampentInstance(int level)
		: base(
				SpeciesLampent.Instance, // PokemonInstance Species
				"Lampent", level,
				Ghost.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lampent Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public LampentInstance() : base(
			SpeciesLampent.Instance, // PokemonInstance Species
			Ghost.Instance, Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
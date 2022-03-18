using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Zweilous Species to store common natural stats of all Zweilouss
	#region SpeciesZweilous
	public class SpeciesZweilous : PokemonSpecies
	{
#nullable enable
		private static SpeciesZweilous? _instance = null;
#nullable restore
        public static SpeciesZweilous Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesZweilous();
                }
                return _instance;
            }
        }

		#region SpeciesZweilous Constructor
		public SpeciesZweilous() : base(
			634,
			"Zweilous",
			1.4,
			50.0,
			72, // HPs
			85, 70, // Attack & Defense
			65, 70, // Special Attack & Defense
			58		
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
				"Slam",
				"Headbutt",
				"Body-Slam",
				"Bite",
				"Roar",
				"Strength",
				"Dragon-Rage",
				"Thunder-Wave",
				"Toxic",
				"Double-Team",
				"Focus-Energy",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Scary-Face",
				"Outrage",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dragon-Breath",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Psych-Up",
				"Rock-Smash",
				"Uproar",
				"Torment",
				"Facade",
				"Taunt",
				"Superpower",
				"Secret-Power",
				"Hyper-Voice",
				"Shock-Wave",
				"Dark-Pulse",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Dragon-Rush",
				"Earth-Power",
				"Zen-Headbutt",
				"Draco-Meteor",
				"Double-Hit",
				"Round",
				"Incinerate",
				"Dragon-Tail",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Zweilous PokemonInstance Class
	#region Zweilous
	public class ZweilousInstance : PokemonInstance
	{
		#region Zweilous Constructors
		/// <summary>
		/// Zweilous Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ZweilousInstance(string nickname, int level)
		: base(
				SpeciesZweilous.Instance, // Pokemon Species
				nickname, level,
				Dark.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zweilous Builder only waiting for a Level
		/// </summary>
		public ZweilousInstance(int level)
		: base(
				SpeciesZweilous.Instance, // PokemonInstance Species
				"Zweilous", level,
				Dark.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zweilous Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ZweilousInstance() : base(
			SpeciesZweilous.Instance, // PokemonInstance Species
			Dark.Instance, Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
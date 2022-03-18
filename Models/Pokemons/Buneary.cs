using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Buneary Species to store common natural stats of all Bunearys
	#region SpeciesBuneary
	public class SpeciesBuneary : PokemonSpecies
	{
#nullable enable
		private static SpeciesBuneary? _instance = null;
#nullable restore
        public static SpeciesBuneary Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesBuneary();
                }
                return _instance;
            }
        }

		#region SpeciesBuneary Constructor
		public SpeciesBuneary() : base(
			427,
			"Buneary",
			0.4,
			5.5,
			55, // HPs
			66, 44, // Attack & Defense
			44, 56, // Special Attack & Defense
			85		
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Cut",
				"Jump-Kick",
				"Headbutt",
				"Ice-Beam",
				"Low-Kick",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Dig",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Double-Team",
				"Defense-Curl",
				"Swift",
				"Dizzy-Punch",
				"Splash",
				"Rest",
				"Substitute",
				"Snore",
				"Flail",
				"Protect",
				"Sweet-Kiss",
				"Mud-Slap",
				"Foresight",
				"Endure",
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Baton-Pass",
				"Encore",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Rock-Smash",
				"Fake-Out",
				"Uproar",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Magic-Coat",
				"Endeavor",
				"Secret-Power",
				"Teeter-Dance",
				"Mud-Sport",
				"Hyper-Voice",
				"Fake-Tears",
				"Cosmic-Power",
				"Sky-Uppercut",
				"Bounce",
				"Covet",
				"Shock-Wave",
				"Water-Pulse",
				"Healing-Wish",
				"Natural-Gift",
				"Fling",
				"Copycat",
				"Last-Resort",
				"Drain-Punch",
				"Switcheroo",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Double-Hit",
				"Entrainment",
				"After-You",
				"Round",
				"Circle-Throw",
				"Retaliate",
				"Work-Up",
				"Confide",
				"Baby-Doll-Eyes",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Buneary PokemonInstance Class
	#region Buneary
	public class BunearyInstance : PokemonInstance
	{
		#region Buneary Constructors
		/// <summary>
		/// Buneary Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public BunearyInstance(string nickname, int level)
		: base(
				SpeciesBuneary.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Buneary Builder only waiting for a Level
		/// </summary>
		public BunearyInstance(int level)
		: base(
				SpeciesBuneary.Instance, // PokemonInstance Species
				"Buneary", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Buneary Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public BunearyInstance() : base(
			SpeciesBuneary.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
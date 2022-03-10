using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Venipede Species to store common natural stats of all Venipedes
	#region SpeciesVenipede
	public class SpeciesVenipede : PokemonSpecies
	{
#nullable enable
		private static SpeciesVenipede? _instance = null;
#nullable restore
        public static SpeciesVenipede Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesVenipede();
                }
                return _instance;
            }
        }

		#region SpeciesVenipede Constructor
		public SpeciesVenipede() : base(
			"Venipede",
			0.4,
			5.3,
			30, // HPs
			45, 59, // Attack & Defense
			30, 39, // Special Attack & Defense
			57		
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
				"Take-Down",
				"Double-Edge",
				"Poison-Sting",
				"Twineedle",
				"Pin-Missile",
				"Solar-Beam",
				"Toxic",
				"Agility",
				"Screech",
				"Double-Team",
				"Defense-Curl",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Sludge-Bomb",
				"Spikes",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Endeavor",
				"Secret-Power",
				"Signal-Beam",
				"Iron-Defense",
				"Poison-Tail",
				"Gyro-Ball",
				"Payback",
				"Toxic-Spikes",
				"Poison-Jab",
				"Rock-Climb",
				"Bug-Bite",
				"Venoshock",
				"Round",
				"Struggle-Bug",
				"Steamroller",
				"Confide",
				"Venom-Drench",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Venipede PokemonInstance Class
	#region Venipede
	public class VenipedeInstance : PokemonInstance
	{
		#region Venipede Constructors
		/// <summary>
		/// Venipede Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public VenipedeInstance(string nickname, int level)
		: base(
				543,
				SpeciesVenipede.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Venipede Builder only waiting for a Level
		/// </summary>
		public VenipedeInstance(int level)
		: base(
				543,
				SpeciesVenipede.Instance, // PokemonInstance Species
				"Venipede", level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Venipede Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Venipede() : base(
			543,
			SpeciesVenipede.Instance, // PokemonInstance Species
			Bug.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
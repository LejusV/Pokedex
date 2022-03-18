using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Kyurem Species to store common natural stats of all Kyurems
	#region SpeciesKyurem
	public class SpeciesKyurem : PokemonSpecies
	{
#nullable enable
		private static SpeciesKyurem? _instance = null;
#nullable restore
        public static SpeciesKyurem Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesKyurem();
                }
                return _instance;
            }
        }

		#region SpeciesKyurem Constructor
		public SpeciesKyurem() : base(
			646,
			"Kyurem",
			3.0,
			325.0,
			125, // HPs
			130, 90, // Attack & Defense
			130, 90, // Special Attack & Defense
			95		
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
				"Cut",
				"Fly",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Strength",
				"Dragon-Rage",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Protect",
				"Scary-Face",
				"Icy-Wind",
				"Outrage",
				"Swagger",
				"Steel-Wing",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dragon-Breath",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Ancient-Power",
				"Shadow-Ball",
				"Rock-Smash",
				"Hail",
				"Facade",
				"Endeavor",
				"Imprison",
				"Secret-Power",
				"Hyper-Voice",
				"Rock-Tomb",
				"Signal-Beam",
				"Dragon-Claw",
				"Roost",
				"Payback",
				"Fling",
				"Dragon-Pulse",
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
				"Shadow-Claw",
				"Zen-Headbutt",
				"Flash-Cannon",
				"Draco-Meteor",
				"Iron-Head",
				"Stone-Edge",
				"Hone-Claws",
				"Round",
				"Echoed-Voice",
				"Dragon-Tail",
				"Glaciate",
				"Noble-Roar",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Kyurem PokemonInstance Class
	#region Kyurem
	public class KyuremInstance : PokemonInstance
	{
		#region Kyurem Constructors
		/// <summary>
		/// Kyurem Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public KyuremInstance(string nickname, int level)
		: base(
				SpeciesKyurem.Instance, // Pokemon Species
				nickname, level,
				Dragon.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kyurem Builder only waiting for a Level
		/// </summary>
		public KyuremInstance(int level)
		: base(
				SpeciesKyurem.Instance, // PokemonInstance Species
				"Kyurem", level,
				Dragon.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kyurem Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public KyuremInstance() : base(
			SpeciesKyurem.Instance, // PokemonInstance Species
			Dragon.Instance, Ice.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
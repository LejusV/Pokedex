using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Elekid Species to store common natural stats of all Elekids
	#region SpeciesElekid
	public class SpeciesElekid : PokemonSpecies
	{
#nullable enable
		private static SpeciesElekid? _instance = null;
#nullable restore
        public static SpeciesElekid Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesElekid();
                }
                return _instance;
            }
        }

		#region SpeciesElekid Constructor
		public SpeciesElekid() : base(
			"Elekid",
			0.6,
			23.5,
			45, // HPs
			63, 37, // Attack & Defense
			65, 55, // Special Attack & Defense
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
				"Karate-Chop",
				"Mega-Punch",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Mega-Kick",
				"Rolling-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Leer",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Thunder-Shock",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Psychic",
				"Meditate",
				"Quick-Attack",
				"Mimic",
				"Screech",
				"Double-Team",
				"Barrier",
				"Light-Screen",
				"Swift",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Zap-Cannon",
				"Detect",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Hidden-Power",
				"Cross-Chop",
				"Rain-Dance",
				"Rock-Smash",
				"Uproar",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Brick-Break",
				"Secret-Power",
				"Signal-Beam",
				"Covet",
				"Shock-Wave",
				"Hammer-Arm",
				"Natural-Gift",
				"Feint",
				"Fling",
				"Magnet-Rise",
				"Discharge",
				"Captivate",
				"Charge-Beam",
				"Electro-Ball",
				"Round",
				"Volt-Switch",
				"Electroweb",
				"Wild-Charge",
				"Dual-Chop",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Elekid PokemonInstance Class
	#region Elekid
	public class ElekidInstance : PokemonInstance
	{
		#region Elekid Constructors
		/// <summary>
		/// Elekid Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ElekidInstance(string nickname, int level)
		: base(
				239,
				SpeciesElekid.Instance, // Pokemon Species
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Elekid Builder only waiting for a Level
		/// </summary>
		public ElekidInstance(int level)
		: base(
				239,
				SpeciesElekid.Instance, // PokemonInstance Species
				"Elekid", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Elekid Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Elekid() : base(
			239,
			SpeciesElekid.Instance, // PokemonInstance Species
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
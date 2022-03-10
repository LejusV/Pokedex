using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Hydreigon Species to store common natural stats of all Hydreigons
	#region SpeciesHydreigon
	public class SpeciesHydreigon : PokemonSpecies
	{
#nullable enable
		private static SpeciesHydreigon? _instance = null;
#nullable restore
        public static SpeciesHydreigon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesHydreigon();
                }
                return _instance;
            }
        }

		#region SpeciesHydreigon Constructor
		public SpeciesHydreigon() : base(
			"Hydreigon",
			1.8,
			160.0,
			92, // HPs
			105, 90, // Attack & Defense
			125, 90, // Special Attack & Defense
			98		
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
				"Fly",
				"Slam",
				"Headbutt",
				"Body-Slam",
				"Bite",
				"Roar",
				"Flamethrower",
				"Surf",
				"Hyper-Beam",
				"Strength",
				"Dragon-Rage",
				"Thunder-Wave",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Reflect",
				"Focus-Energy",
				"Fire-Blast",
				"Rest",
				"Rock-Slide",
				"Tri-Attack",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Scary-Face",
				"Outrage",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dragon-Breath",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Psych-Up",
				"Rock-Smash",
				"Uproar",
				"Heat-Wave",
				"Torment",
				"Facade",
				"Taunt",
				"Superpower",
				"Secret-Power",
				"Hyper-Voice",
				"Rock-Tomb",
				"Signal-Beam",
				"Shock-Wave",
				"Roost",
				"Tailwind",
				"U-Turn",
				"Payback",
				"Dark-Pulse",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Dragon-Rush",
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
				"Zen-Headbutt",
				"Flash-Cannon",
				"Draco-Meteor",
				"Stone-Edge",
				"Charge-Beam",
				"Round",
				"Echoed-Voice",
				"Incinerate",
				"Acrobatics",
				"Bulldoze",
				"Dragon-Tail",
				"Work-Up",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Hydreigon PokemonInstance Class
	#region Hydreigon
	public class HydreigonInstance : PokemonInstance
	{
		#region Hydreigon Constructors
		/// <summary>
		/// Hydreigon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public HydreigonInstance(string nickname, int level)
		: base(
				635,
				SpeciesHydreigon.Instance, // Pokemon Species
				nickname, level,
				Dark.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hydreigon Builder only waiting for a Level
		/// </summary>
		public HydreigonInstance(int level)
		: base(
				635,
				SpeciesHydreigon.Instance, // PokemonInstance Species
				"Hydreigon", level,
				Dark.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hydreigon Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Hydreigon() : base(
			635,
			SpeciesHydreigon.Instance, // PokemonInstance Species
			Dark.Instance, Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
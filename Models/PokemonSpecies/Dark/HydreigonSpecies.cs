using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Hydreigon Species to store common natural stats of all Hydreigons
	#region HydreigonSpecies
	public class HydreigonSpecies : PokemonSpecies
	{
#nullable enable
		private static HydreigonSpecies? _instance = null;
#nullable restore
        public static HydreigonSpecies Instance => _instance ?? (_instance = new HydreigonSpecies());

		#region HydreigonSpecies Constructor
		public HydreigonSpecies() : base(
			635,
			"Hydreigon",
			Dark.Instance, Dragon.Instance,
			1.8,
			160.0,
			new PokemonStats(
				92, // HPs
				105, 90, // Attack & Defense
				125, 90, // Spacial Attack & Defense
				98 // Speed
			)			
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
}
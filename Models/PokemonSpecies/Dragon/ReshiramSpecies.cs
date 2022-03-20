using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Reshiram Species to store common natural stats of all Reshirams
	#region ReshiramSpecies
	public class ReshiramSpecies : PokemonSpecies
	{
#nullable enable
		private static ReshiramSpecies? _instance = null;
#nullable restore
        public static ReshiramSpecies Instance => _instance ?? (_instance = new ReshiramSpecies());

		#region ReshiramSpecies Constructor
		public ReshiramSpecies() : base(
			643,
			"Reshiram",
			Dragon.Instance, Fire.Instance,
			3.2,
			330.0,
			new PokemonStats(
				100, // HPs
				120, 100, // Attack & Defense
				150, 120, // Spacial Attack & Defense
				90 // Speed
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
				"Cut",
				"Fly",
				"Flamethrower",
				"Hyper-Beam",
				"Strength",
				"Solar-Beam",
				"Dragon-Rage",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Fire-Blast",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Protect",
				"Outrage",
				"Swagger",
				"Steel-Wing",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dragon-Breath",
				"Hidden-Power",
				"Sunny-Day",
				"Crunch",
				"Ancient-Power",
				"Shadow-Ball",
				"Rock-Smash",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Imprison",
				"Secret-Power",
				"Hyper-Voice",
				"Overheat",
				"Rock-Tomb",
				"Extrasensory",
				"Dragon-Claw",
				"Roost",
				"Tailwind",
				"Payback",
				"Fling",
				"Dragon-Pulse",
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
				"Shadow-Claw",
				"Fire-Fang",
				"Zen-Headbutt",
				"Draco-Meteor",
				"Stone-Edge",
				"Hone-Claws",
				"Flame-Charge",
				"Round",
				"Echoed-Voice",
				"Incinerate",
				"Dragon-Tail",
				"Blue-Flare",
				"Fusion-Flare",
				"Noble-Roar",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}
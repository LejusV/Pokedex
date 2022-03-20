using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Kyurem Species to store common natural stats of all Kyurems
	#region KyuremSpecies
	public class KyuremSpecies : PokemonSpecies
	{
#nullable enable
		private static KyuremSpecies? _instance = null;
#nullable restore
        public static KyuremSpecies Instance => _instance ?? (_instance = new KyuremSpecies());

		#region KyuremSpecies Constructor
		public KyuremSpecies() : base(
			646,
			"Kyurem",
			Dragon.Instance, Ice.Instance,
			3.0,
			325.0,
			new PokemonStats(
				125, // HPs
				130, 90, // Attack & Defense
				130, 90, // Spacial Attack & Defense
				95 // Speed
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
}
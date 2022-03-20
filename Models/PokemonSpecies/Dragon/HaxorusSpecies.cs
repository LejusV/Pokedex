using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Haxorus Species to store common natural stats of all Haxoruss
	#region HaxorusSpecies
	public class HaxorusSpecies : PokemonSpecies
	{
#nullable enable
		private static HaxorusSpecies? _instance = null;
#nullable restore
        public static HaxorusSpecies Instance => _instance ?? (_instance = new HaxorusSpecies());

		#region HaxorusSpecies Constructor
		public HaxorusSpecies() : base(
			612,
			"Haxorus",
			Dragon.Instance,
			1.8,
			105.5,
			new PokemonStats(
				76, // HPs
				147, 90, // Attack & Defense
				60, 70, // Spacial Attack & Defense
				97 // Speed
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
				"Scratch",
				"Guillotine",
				"Swords-Dance",
				"Cut",
				"Leer",
				"Roar",
				"Surf",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Dragon-Rage",
				"Earthquake",
				"Dig",
				"Toxic",
				"Double-Team",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Protect",
				"Scary-Face",
				"Outrage",
				"False-Swipe",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Taunt",
				"Superpower",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Rock-Tomb",
				"Aerial-Ace",
				"Dragon-Claw",
				"Dragon-Dance",
				"Shock-Wave",
				"Payback",
				"Assurance",
				"Fling",
				"Poison-Jab",
				"Aqua-Tail",
				"X-Scissor",
				"Dragon-Pulse",
				"Focus-Blast",
				"Giga-Impact",
				"Shadow-Claw",
				"Draco-Meteor",
				"Grass-Knot",
				"Hone-Claws",
				"Round",
				"Incinerate",
				"Bulldoze",
				"Dragon-Tail",
				"Dual-Chop",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}
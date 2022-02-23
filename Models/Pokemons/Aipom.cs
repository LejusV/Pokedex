using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Aipom Specie to store common natural stats of every {'abilities': ['run-away', 'pickup', 'skill-link'], 'base_experience': 72, 'height': 8, 'id': 190, 'moves': ['double-slap', 'mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'scratch', 'cut', 'slam', 'mega-kick', 'sand-attack', 'headbutt', 'body-slam', 'double-edge', 'tail-whip', 'low-kick', 'counter', 'seismic-toss', 'strength', 'solar-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'dig', 'toxic', 'agility', 'mimic', 'screech', 'double-team', 'defense-curl', 'metronome', 'swift', 'dream-eater', 'fury-swipes', 'rest', 'substitute', 'thief', 'nightmare', 'snore', 'curse', 'spite', 'protect', 'mud-slap', 'zap-cannon', 'detect', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'baton-pass', 'pursuit', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'shadow-ball', 'rock-smash', 'beat-up', 'fake-out', 'uproar', 'facade', 'focus-punch', 'taunt', 'role-play', 'revenge', 'brick-break', 'knock-off', 'snatch', 'secret-power', 'astonish', 'tickle', 'aerial-ace', 'bounce', 'covet', 'shock-wave', 'water-pulse', 'natural-gift', 'u-turn', 'payback', 'fling', 'last-resort', 'seed-bomb', 'switcheroo', 'nasty-plot', 'shadow-claw', 'gunk-shot', 'captivate', 'grass-knot', 'double-hit', 'hone-claws', 'low-sweep', 'foul-play', 'round', 'quick-guard', 'acrobatics', 'retaliate', 'work-up', 'tail-slap', 'confide', 'power-up-punch'], 'name': 'aipom', 'stats': {'hp': 55, 'attack': 70, 'defense': 55, 'special-attack': 40, 'special-defense': 55, 'speed': 85}, 'types': ['normal'], 'weight': 115, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'purple', 'shape': 'upright', 'habitat': 'forest', 'generation': 'generation-ii', 'growth_rate': 'fast', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'エイパム', 'roomaji': 'Eipam', 'ko': '에이팜', 'zh-Hant': '長尾怪手', 'fr': 'Capumain', 'de': 'Griffel', 'es': 'Aipom', 'it': 'Aipom', 'en': 'Aipom', 'ja': 'エイパム', 'zh-Hans': '长尾怪手'}, 'genera': {'ja-Hrkt': 'おながポケモン', 'ko': '긴꼬리포켓몬', 'zh-Hant': '長尾寶可夢', 'fr': 'Pokémon Longqueue', 'de': 'Langschweif', 'es': 'Pokémon Cola Larga', 'it': 'Pokémon Lungacoda', 'en': 'Long Tail Pokémon', 'ja': 'おながポケモン', 'zh-Hans': '长尾宝可梦'}}
	public class SpecieAipom : PokemonSpecie
	{
#nullable enable
		private static SpecieAipom? _instance = null;
#nullable restore
        public static SpecieAipom Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAipom();
                }
                return _instance;
            }
        }

		public SpecieAipom() : base(
			"Aipom",
			55, // HPs
			70, 55, // Attack & Defense
			40, 55, // Special Attack & Defense
			85			
		) {}
	}


	//Aipom Pokemon Class
	public class Aipom : Pokemon
	{

		public Aipom(string nickname, int level) : base(
			190,
			SpecieAipom.Instance, // Pokemon Specie
			nickname, level,
			Normal.Instance			
		) {}

		public Aipom() : base(
			190,
			SpecieAipom.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}